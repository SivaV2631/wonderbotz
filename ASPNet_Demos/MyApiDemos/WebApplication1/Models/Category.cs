using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table(name: "Categories")]
    public class Category
    {
        [Key]                                                       // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]       // Identity Column
        [Display(Name = "Category ID")]                             // Label on the UI
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty!")]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Name of the Category")]                    // Label on the UI
        public string CategoryName { get; set; } = string.Empty;

        [Required(ErrorMessage = "{0} cannot be empty!")]
        [Display(Name = "Description")]                             // Label on the UI
        [StringLength(200, ErrorMessage = "{0} cannot be longer than {1} characters")]
        public string? Description { get; set; }
    }


    /**************
     *      CREATE TABLE [Categories]
     *      (
     *          [CategoryId] int NOT NULL IDENTITY (1,1)
     *          , [CategoryName] varchar(50) NOT NULL
     *          , [Description] nvarchar(200) NULL
     *          
     *          , CONSTRAINT [PK_Categories] PRIMARY KEY ( [CategoryId] ASC )
     *      )
     *****/
}
