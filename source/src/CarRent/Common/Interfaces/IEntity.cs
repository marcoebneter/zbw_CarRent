using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace CarRent.Common.Interfaces
{
    public interface IEntity<T>
    {
        [Key]
        T id { get; set; }
    }
}
