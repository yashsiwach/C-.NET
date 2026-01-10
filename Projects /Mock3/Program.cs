using System.Runtime.CompilerServices;

// Interface defining broadband plan behavior
interface IBroadbandPlan
{
    // Returns final payable amount of the plan
    int GetBroadbandPlanAmount();
}

// Black broadband plan implementation
class Black : IBroadbandPlan
{
    // Indicates whether subscription is valid
    readonly bool _isSubscriptionValid;

    // Discount percentage for the plan
    readonly int _discountPercentage;

    // Fixed base amount for Black plan
    private const int PlanAmount = 3000;

    // Constructor to initialize subscription status and discount
    public Black(bool _isSubscriptionValid, int _discountPercentage)
    {
        this._isSubscriptionValid = _isSubscriptionValid;

        // Validate discount range
        if (_discountPercentage < 0 || _discountPercentage > 50)
        {
            throw new ArgumentOutOfRangeException("enter in 0 to 50");
        }

        this._discountPercentage = _discountPercentage;
    }

    // Calculates final amount after discount (if applicable)
    public int GetBroadbandPlanAmount()
    {
        if (_isSubscriptionValid)
        {
            return PlanAmount - (int)((double)PlanAmount * ((double)_discountPercentage / 100.00));
        }
        else
        {
            return PlanAmount;
        }
    }
}

// Gold broadband plan implementation
class Gold : IBroadbandPlan
{
    // Indicates whether subscription is valid
    readonly bool _isSubscriptionValid;

    // Discount percentage for the plan
    readonly int _discountPercentage;

    // Fixed base amount for Gold plan
    private const int PlanAmount = 1500;

    // Constructor to initialize subscription status and discount
    public Gold(bool _isSubscriptionValid, int _discountPercentage)
    {
        this._isSubscriptionValid = _isSubscriptionValid;

        // Validate discount range
        if (_discountPercentage < 0 || _discountPercentage > 30)
        {
            throw new ArgumentOutOfRangeException("enter in 0 to 30");
        }

        this._discountPercentage = _discountPercentage;
    }

    // Calculates final amount after discount (if applicable)
    public int GetBroadbandPlanAmount()
    {
        if (_isSubscriptionValid)
        {
            return PlanAmount - (int)((double)PlanAmount * ((double)_discountPercentage / 100.00));
        }
        else
        {
            return PlanAmount;
        }
    }
}

// Class responsible for managing subscriptions
class SubscribePlan
{
    // Collection of all subscribed customers
    private readonly IList<IBroadbandPlan> _customers = new List<IBroadbandPlan>();

    // Constructor to initialize customer list
    public SubscribePlan(IList<IBroadbandPlan> broadbandPlans)
    {
        if (broadbandPlans == null)
        {
            throw new ArgumentNullException("null value found");
        }

        _customers = broadbandPlans;
    }

    // Returns plan name and final amount for each customer
    public IList<Tuple<string, int>> GetSubscriptionPlan()
    {
        IList<Tuple<string, int>> ans = new List<Tuple<string, int>>();

        // Iterate through each subscribed customer
        foreach (var i in _customers)
        {
            // Identify plan type
            string plan = i is Black ? "Black" : "Gold";

            // Get payable amount
            int val = i.GetBroadbandPlanAmount();

            // Store result as tuple (PlanName, Amount)
            ans.Add(new Tuple<string, int>(plan, val));
        }

        return ans;
    }
}

// Application entry point
public class Program
{
    public static void Main()
    {
        // Creating broadband plans for customers
        var plans = new List<IBroadbandPlan>
        {
            new Black(true, 50),
            new Black(false, 10),
            new Gold(true, 30),
            new Black(true, 20),
            new Gold(false, 20)
        };

        // Processing subscription plans
        var subscriptionPlans = new SubscribePlan(plans);

        // Fetching final plan details
        var result = subscriptionPlans.GetSubscriptionPlan();

        // Displaying plan name and payable amount
        foreach (var item in result)
        {
            Console.WriteLine($"{item.Item1},{item.Item2}");
        }
    }
}
