using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Flight.Models;

public class SearchViewModel
{
    [Required(ErrorMessage = "Please select a source location.")]
    public string Source { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select a destination location.")]
    public string Destination { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter number of persons.")]
    [Range(1, 10, ErrorMessage = "Number of persons must be between 1 and 10.")]
    [Display(Name = "Number of Persons")]
    public int NumberOfPersons { get; set; }

    public SelectList? SourceList { get; set; }
    public SelectList? DestinationList { get; set; }
}
