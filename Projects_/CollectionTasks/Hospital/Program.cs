using System;
using System.Collections.Generic;
using System.Linq;

public interface IPatient
{
    int PatientId { get; }
    string Name { get; }
    DateTime DateOfBirth { get; }
    BloodType BloodType { get; }
}

public enum BloodType { A, B, AB, O }
public enum Condition { Stable, Critical, Recovering }

// 1. Generic patient priority queue
public class PriorityQueue<T> where T : IPatient
{
    private SortedDictionary<int, Queue<T>> _queues = new();

    public void Enqueue(T patient, int priority)
    {
        if (priority < 1 || priority > 5) return;

        if (!_queues.ContainsKey(priority))
            _queues[priority] = new Queue<T>();

        _queues[priority].Enqueue(patient);
    }

    public T Dequeue()
    {
        foreach (var q in _queues)
        {
            if (q.Value.Count > 0)
                return q.Value.Dequeue();
        }
        throw new InvalidOperationException("Queue is empty");
    }

    public T Peek()
    {
        foreach (var q in _queues)
        {
            if (q.Value.Count > 0)
                return q.Value.Peek();
        }
        throw new InvalidOperationException("Queue is empty");
    }

    public int GetCountByPriority(int priority)
    {
        return _queues.ContainsKey(priority) ? _queues[priority].Count : 0;
    }
}

// 2. Medical Record
public class MedicalRecord<T> where T : IPatient
{
    private T _patient;
    private List<(DateTime date, string diagnosis)> _diagnoses = new();
    private Dictionary<DateTime, string> _treatments = new();

    public MedicalRecord(T patient)
    {
        _patient = patient;
    }

    public void AddDiagnosis(string diagnosis, DateTime date)
    {
        _diagnoses.Add((date, diagnosis));
    }

    public void AddTreatment(string treatment, DateTime date)
    {
        _treatments[date] = treatment;
    }

    public IEnumerable<KeyValuePair<DateTime, string>> GetTreatmentHistory()
    {
        return _treatments.OrderBy(x => x.Key);
    }
}

// 3. Patient types
public class PediatricPatient : IPatient
{
    public int PatientId { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public BloodType BloodType { get; set; }
    public string GuardianName { get; set; }
    public double Weight { get; set; }
}

public class GeriatricPatient : IPatient
{
    public int PatientId { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public BloodType BloodType { get; set; }
    public List<string> ChronicConditions { get; } = new();
    public int MobilityScore { get; set; }
}

// 4. Medication system
public class MedicationSystem<T> where T : IPatient
{
    private Dictionary<T, List<(string medication, DateTime time)>> _medications = new();

    public void PrescribeMedication(T patient, string medication, Func<T, bool> dosageValidator)
    {
        if (!dosageValidator(patient)) return;

        if (!_medications.ContainsKey(patient))
            _medications[patient] = new List<(string, DateTime)>();

        _medications[patient].Add((medication, DateTime.Now));
    }

    public bool CheckInteractions(T patient, string newMedication)
    {
        if (!_medications.ContainsKey(patient)) return false;

        foreach (var m in _medications[patient])
        {
            if (m.medication == newMedication)
                return true;
        }
        return false;
    }
}

// 5. TEST SCENARIO
public class Program
{
    public static void Main()
    {
        var p1 = new PediatricPatient
        {
            PatientId = 1,
            Name = "Child A",
            DateOfBirth = DateTime.Now.AddYears(-5),
            BloodType = BloodType.A,
            Weight = 18
        };

        var p2 = new PediatricPatient
        {
            PatientId = 2,
            Name = "Child B",
            DateOfBirth = DateTime.Now.AddYears(-7),
            BloodType = BloodType.B,
            Weight = 12
        };

        var g1 = new GeriatricPatient
        {
            PatientId = 3,
            Name = "Elder A",
            DateOfBirth = DateTime.Now.AddYears(-70),
            BloodType = BloodType.O,
            MobilityScore = 6
        };

        var g2 = new GeriatricPatient
        {
            PatientId = 4,
            Name = "Elder B",
            DateOfBirth = DateTime.Now.AddYears(-80),
            BloodType = BloodType.AB,
            MobilityScore = 4
        };

        var queue = new PriorityQueue<IPatient>();
        queue.Enqueue(p1, 2);
        queue.Enqueue(g1, 1);
        queue.Enqueue(p2, 3);
        queue.Enqueue(g2, 2);

        Console.WriteLine(queue.Dequeue().Name);

        var record = new MedicalRecord<IPatient>(p1);
        record.AddDiagnosis("Fever", DateTime.Now.AddDays(-2));
        record.AddTreatment("Paracetamol", DateTime.Now.AddDays(-1));

        foreach (var t in record.GetTreatmentHistory())
            Console.WriteLine(t.Key + " -> " + t.Value);

        var meds = new MedicationSystem<IPatient>();

        meds.PrescribeMedication(
            p1,
            "Syrup-A",
            x => x is PediatricPatient pp && pp.Weight >= 10
        );

        Console.WriteLine(meds.CheckInteractions(p1, "Syrup-A"));
    }
}