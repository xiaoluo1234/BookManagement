using System;
using Volo.Abp;

namespace BookManagement.EquipmentTypes.Exceptions;

/// <summary>
/// 【设备类型】实体不存在的异常信息
/// </summary>
[Serializable]
public class EquipmentTypeNotFoundException: UserFriendlyException
{
    /// <summary>
    /// 【设备类型】实体不存在的异常信息
    /// </summary>
    public EquipmentTypeNotFoundException()
        : base(
            "设备类型信息不存在",
                        EquipmentsErrorCodes.EquipmentType.NotFoundCode,
            "设备类型信息不存在")
    {
    }

    /// <summary>
    /// 【设备类型】实体不存在的异常信息
    /// <param name="id">设备类型的 ID</param>
    /// </summary>
    public EquipmentTypeNotFoundException(Guid id)
        : base(
            "未根据设备类型 ID 查询到信息",
                        EquipmentsErrorCodes.EquipmentType.NotFoundCode,
            "未根据设备类型 ID 查询到信息")
    {
    }
}

