using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Equipments
{
    public interface IEquipmentFilter
    {
        /// <summary>
        /// 获取用户所在部门对设备的过滤
        /// </summary>
        /// <returns></returns>
        public Task<IQueryable<Equipment>> GetEquipmentQuerableAsync();
    }
}