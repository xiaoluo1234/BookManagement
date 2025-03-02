using System;
using Volo.Abp;

namespace BookManagement.Equipments.Exception;

/// <summary>
/// 【设备定义 定义一个设备】实体不存在的异常信息
/// </summary>
[Serializable]
public class EquipmentNotFoundException: UserFriendlyException
{
    /// <summary>
    /// 【设备定义 定义一个设备】实体不存在的异常信息
    /// </summary>
    public EquipmentNotFoundException()
        : base(
            "设备定义 定义一个设备信息不存在",
                        EquipmentsErrorCodes.Equipment.NotFoundCode,
            "设备定义 定义一个设备信息不存在")
    {
    }

    /// <summary>
    /// 【设备定义 定义一个设备】实体不存在的异常信息
    /// <param name="id">设备定义 定义一个设备的 ID</param>
    /// </summary>
    public EquipmentNotFoundException(Guid id)
        : base(
            "未根据设备定义 定义一个设备 ID 查询到信息",
                        EquipmentsErrorCodes.Equipment.NotFoundCode,
            "未根据设备定义 定义一个设备 ID 查询到信息")
    {
    }
}

