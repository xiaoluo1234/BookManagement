using System;
using Volo.Abp;

namespace BookManagement.EquipmentTypes.Exceptions;

/// <summary>
/// 【设备类型】已存在的异常信息
/// </summary>
[Serializable]
public class EquipmentTypeAlreadyExistException: UserFriendlyException
{
    /// <summary>
    /// 【设备类型】已存在的异常信息
    /// </summary>
    public EquipmentTypeAlreadyExistException()
        : base(
            "设备类型信息已存在",
                        EquipmentsErrorCodes.EquipmentType.AlreadyExistCode,
            "设备类型信息已存在")
    {
    }
}

