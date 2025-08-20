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
    [RegularExpression("[A-Za-z ]", ErrorMessage = "Common name can only contain letters and spaceses (A-Z, a-z, ")]
    public required string CommonName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the biological class of the animal (e.g., "Mammalia").
    /// </summary>
    [Required(ErrorMessage = "You must provide a class the animal belongs to")]
    [StringLength(128)]
    [RegularExpression("[A-Za-z ]", ErrorMessage = "Class can only contain letters and spaceses (A-Z, a-z, ")]
    public required string Class { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the family of the animal (e.g., "Elephantidae").
    /// </summary>
    [Required(ErrorMessage = "You must provide a family the animal belongs to")]
    [StringLength(128)]
    [RegularExpression("[A-Za-z ]", ErrorMessage = "Family can only contain letters and spaceses (A-Z, a-z, ")]
    public required string Family { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the genus of the animal (e.g., "Loxodonta").
    /// </summary>
    [Required(ErrorMessage = "You must provide a genus the animal belongs to")]
    [StringLength(128)]
    [RegularExpression("[A-Za-z ]", ErrorMessage = "Genus can only contain letters and spaceses (A-Z, a-z, ")]
    public required string Genus { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the lifespan range of the animal in years.
    /// </summary>
    [Required(ErrorMessage = "You must provide the average lifespan of the animal")]
    [Range(0, int.MaxValue)]
    public required Range LifeSpan { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Animal"/> class.
    /// </summary>
    /// <param name="id">The unique identifier of the animal.</param>
    /// <param name="commonName">The common name of the animal.</param>
    /// <param name="class">The biological class of the animal.</param>
    /// <param name="family">The family of the animal.</param>
    /// <param name="genus">The genus of the animal.</param>
    /// <param name="lifeSpan">The lifespan range of the animal.</param>
    public Animal(int id, string commonName, string @class, string family, string genus, Range lifeSpan)
    {
        Id = id;
        CommonName = commonName;
        Class = @class;
        Family = family;
        Genus = genus;
        LifeSpan = lifeSpan;
    }
}
