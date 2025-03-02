using System;
using Volo.Abp;

namespace BookManagement.Equipments.Exception;

/// <summary>
/// 【设备定义 定义一个设备】已存在的异常信息
/// </summary>
[Serializable]
public class EquipmentAlreadyExistException: UserFriendlyException
{
    /// <summary>
    /// 【设备定义 定义一个设备】已存在的异常信息
    /// </summary>
    public EquipmentAlreadyExistException()
        : base(
            "设备定义 定义一个设备信息已存在",
                        EquipmentsErrorCodes.Equipment.AlreadyExistCode,
            "设备定义 定义一个设备信息已存在")
    {
    }
}

