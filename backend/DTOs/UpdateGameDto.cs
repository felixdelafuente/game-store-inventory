using System.ComponentModel.DataAnnotations;

namespace backend.DTOs;

public record class UpdateGameDto(
  [Required]
  [StringLength(50)]
  string Name,

  [Required]
  [StringLength(20)]
  string Genre,

  [Required]
  [Range(1, 100)]
  decimal Price,

  DateOnly ReleaseDate
);
