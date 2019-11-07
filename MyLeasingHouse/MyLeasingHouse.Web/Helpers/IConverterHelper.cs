using System.Threading.Tasks;
using MyLeasing.Web.Data.Entities;
using MyLeasing.Web.Models;

namespace MyLeasingHouse.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Property> ToPropertyAsync(PropertyViewModel model, bool isNew);
    }
}