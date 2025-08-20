using System.ComponentModel.DataAnnotations;

namespace MVC_Modelbinding.Models;

/// <summary>
/// Represents an individual animal with its taxonomic classification and lifespan.
/// </summary>
public class Animal
{
    /// <summary>
    /// Gets or sets the unique identifier for the animal.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the common name of the animal (e.g., "Elephant").
    /// </summary>
    [Required(ErrorMessage = "You must provide the animal's common name")]
    [StringLength(128)]
    [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Common name can only contain letters and spaces (A–Z, a–z)")]
    public required string CommonName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the biological class of the animal (e.g., "Mammalia").
    /// </summary>
    [Required(ErrorMessage = "You must provide a class the animal belongs to")]
    [StringLength(128)]
    [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Class can only contain letters and spaces (A–Z, a–z)")]
    public required string Class { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the family of the animal (e.g., "Elephantidae").
    /// </summary>
    [Required(ErrorMessage = "You must provide a family the animal belongs to")]
    [StringLength(128)]
    [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Family can only contain letters and spaces (A–Z, a–z)")]
    public required string Family { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the genus of the animal (e.g., "Loxodonta").
    /// </summary>
    [Required(ErrorMessage = "You must provide a genus the animal belongs to")]
    [StringLength(128)]
    [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Genus can only contain letters and spaces (A–Z, a–z)")]
    public required string Genus { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the lifespan range of the animal in years.
    /// </summary>
    [Required(ErrorMessage = "You must provide the average lifespan of the animal")]
    public required LifeSpan LifeSpan { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Animal"/> class.
    /// </summary>
    public Animal(int id, string commonName, string @class, string family, string genus, LifeSpan lifeSpan)
    {
        Id = id;
        CommonName = commonName;
        Class = @class;
        Family = family;
        Genus = genus;
        LifeSpan = lifeSpan;
    }
}

/// <summary>
/// Represents a lifespan range in years.
/// </summary>
public class LifeSpan
{
    [Range(0, 1000)]
    public ushort Min { get; set; }

    [Range(0, 1000)]
    public ushort Max { get; set; }

    public override string ToString() => $"{Min} - {Max} years";
}
