using Arim.Ims.Equipments.Equipments;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Arim.Ims.Equipments.EntityExtensions
{
    [IntegrationService]
    public interface IEntityExtensionIntegrationService : IApplicationService
    {
        /// <summary>
        /// 获取设备特性
        /// </summary>
        /// <param name="equipmentCode"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<EquipmentPropertyDto>> GetEntityPropertiesAsync(string equipmentCode, EntityExtensionGetListInput input);
    }
}
