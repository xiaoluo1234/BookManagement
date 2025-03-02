namespace BookManagement;

public static class EquipmentsErrorCodes
{
    //Add your business exception error codes here...

    /// <summary>
    /// 【EquipmentLocationDto】
    /// </summary>
    public class EquipmentLocation
    {
        /// <summary>
        /// EquipmentLocationDto已经存在
        /// </summary>
        public const string AlreadyExistCode = "Equipments:EquipmentLocation:AlreadyExist";

        /// <summary>
        ///  EquipmentLocationDto不存在
        /// </summary>
        public const string NotFoundCode = "Equipments:EquipmentLocation:NotFound";

        /// <summary>
        ///  EquipmentLocationDto（父项）不存在
        /// </summary>
        public const string ParentNotFound = "Equipments:EquipmentLocation:ParentNotFound";

        /// <summary>
        ///  EquipmentLocationDto的编号不能修改
        /// </summary>
        public const string NoImmutableCode = "Equipments:EquipmentLocation:NoImmutable";
    }
    /// <summary>
    /// 【设备分类】
    /// </summary>
    public class EquipmentCategory
    {
        /// <summary>
        /// 设备分类已经存在
        /// </summary>
        public const string AlreadyExistCode = "Equipments:EquipmentCategory:AlreadyExist";

        /// <summary>
        ///  设备分类不存在
        /// </summary>
        public const string NotFoundCode = "Equipments:EquipmentCategory:NotFound";

        /// <summary>
        ///  设备分类（父项）不存在
        /// </summary>
        public const string ParentNotFound = "Equipments:EquipmentCategory:ParentNotFound";

        /// <summary>
        ///  设备分类的编号不能修改
        /// </summary>
        public const string NoImmutableCode = "Equipments:EquipmentCategory:NoImmutable";
    }

    /// <summary>
    /// 【产品定义】
    /// </summary>
    public class Product
    {
        /// <summary>
        /// 产品定义已经存在
        /// </summary>
        public const string AlreadyExistCode = "Equipments:Product:AlreadyExist";

        /// <summary>
        ///  产品定义不存在
        /// </summary>
        public const string NotFoundCode = "Equipments:Product:NotFound";

        /// <summary>
        ///  产品定义（父项）不存在
        /// </summary>
        public const string ParentNotFound = "Equipments:Product:ParentNotFound";

        /// <summary>
        ///  产品定义的编号不能修改
        /// </summary>
        public const string NoImmutableCode = "Equipments:Product:NoImmutable";
    }

    /// <summary>
    /// 【设备类型】
    /// </summary>
    public class EquipmentType
    {
        /// <summary>
        /// 设备类型已经存在
        /// </summary>
        public const string AlreadyExistCode = "Equipments:EquipmentType:AlreadyExist";

        /// <summary>
        ///  设备类型不存在
        /// </summary>
        public const string NotFoundCode = "Equipments:EquipmentType:NotFound";

        /// <summary>
        ///  设备类型（父项）不存在
        /// </summary>
        public const string ParentNotFound = "Equipments:EquipmentType:ParentNotFound";

        /// <summary>
        ///  设备类型的编号不能修改
        /// </summary>
        public const string NoImmutableCode = "Equipments:EquipmentType:NoImmutable";
    }

    /// <summary>
    /// 【设备定义 定义一个设备】
    /// </summary>
    public class Equipment
    {
        /// <summary>
        /// 设备定义 定义一个设备已经存在
        /// </summary>
        public const string AlreadyExistCode = "Equipments:Equipment:AlreadyExist";

        /// <summary>
        ///  设备定义 定义一个设备不存在
        /// </summary>
        public const string NotFoundCode = "Equipments:Equipment:NotFound";

        /// <summary>
        ///  设备定义 定义一个设备（父项）不存在
        /// </summary>
        public const string ParentNotFound = "Equipments:Equipment:ParentNotFound";

        /// <summary>
        ///  设备定义 定义一个设备的编号不能修改
        /// </summary>
        public const string NoImmutableCode = "Equipments:Equipment:NoImmutable";
    }

    /// <summary>
    /// 【历史事件记录表】
    /// </summary>
    public class EventRecord
    {
        /// <summary>
        /// 历史事件记录表 已经存在
        /// </summary>
        public const string AlreadyExistCode = "Equipments:EventRecord:AlreadyExist";

        /// <summary>
        ///  历史事件记录表 不存在
        /// </summary>
        public const string NotFoundCode = "Equipments:EventRecord:NotFound";

        /// <summary>
        ///  历史事件记录表 （父项）不存在
        /// </summary>
        public const string ParentNotFound = "Equipments:EventRecord:ParentNotFound";

        /// <summary>
        ///  历史事件记录表 的编号不能修改
        /// </summary>
        public const string NoImmutableCode = "Equipments:EventRecord:NoImmutable";
    }

    /// <summary>
    /// 【厂商定义】
    /// </summary>
    public class Manufacturer
    {
        /// <summary>
        /// 已经存在
        /// </summary>
        public const string AlreadyExistCode = "Equipments:Manufacturer:AlreadyExist";

        /// <summary>
        ///  不存在
        /// </summary>
        public const string NotFoundCode = "Equipments:Manufacturer:NotFound";

        /// <summary>
        ///  （父项）不存在
        /// </summary>
        public const string ParentNotFound = "Equipments:Manufacturer:ParentNotFound";

        /// <summary>
        ///  的编号不能修改
        /// </summary>
        public const string NoImmutableCode = "Equipments:Manufacturer:NoImmutable";
    }

    /// <summary>
    /// 【设备之间的关系定义】
    /// </summary>
    public class EquipmentRelation
    {
        /// <summary>
        /// 设备之间的关系定义 已经存在
        /// </summary>
        public const string AlreadyExistCode = "Equipments:EquipmentRelation:AlreadyExist";

        /// <summary>
        ///  设备之间的关系定义 不存在
        /// </summary>
        public const string NotFoundCode = "Equipments:EquipmentRelation:NotFound";

        /// <summary>
        ///  设备之间的关系定义 （父项）不存在
        /// </summary>
        public const string ParentNotFound = "Equipments:EquipmentRelation:ParentNotFound";

        /// <summary>
        ///  设备之间的关系定义 的编号不能修改
        /// </summary>
        public const string NoImmutableCode = "Equipments:EquipmentRelation:NoImmutable";
    }

    /// <summary>
    /// 【设备状态快照】
    /// </summary>
    public class EquipmentState
    {
        /// <summary>
        /// 设备状态快照已经存在
        /// </summary>
        public const string AlreadyExistCode = "Equipments:EquipmentState:AlreadyExist";

        /// <summary>
        ///  设备状态快照不存在
        /// </summary>
        public const string NotFoundCode = "Equipments:EquipmentState:NotFound";

        /// <summary>
        ///  设备状态快照（父项）不存在
        /// </summary>
        public const string ParentNotFound = "Equipments:EquipmentState:ParentNotFound";

        /// <summary>
        ///  设备状态快照的编号不能修改
        /// </summary>
        public const string NoImmutableCode = "Equipments:EquipmentState:NoImmutable";

    }

    /// <summary>
    /// 【Position】
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Position已经存在
        /// </summary>
        public const string AlreadyExistCode = "Equipments:Position:AlreadyExist";

        /// <summary>
        ///  Position不存在
        /// </summary>
        public const string NotFoundCode = "Equipments:Position:NotFound";

        /// <summary>
        ///  Position（父项）不存在
        /// </summary>
        public const string ParentNotFound = "Equipments:Position:ParentNotFound";

        /// <summary>
        ///  Position的编号不能修改
        /// </summary>
        public const string NoImmutableCode = "Equipments:Position:NoImmutable";
    }

    /// <summary>
    /// 【设备资源】
    /// </summary>
    public class EquipmentResource
    {
        /// <summary>
        /// 设备资源已经存在
        /// </summary>
        public const string AlreadyExistCode = "Equipments:EquipmentResource:AlreadyExist";

        /// <summary>
        ///  设备资源不存在
        /// </summary>
        public const string NotFoundCode = "Equipments:EquipmentResource:NotFound";

        /// <summary>
        ///  设备资源（父项）不存在
        /// </summary>
        public const string ParentNotFound = "Equipments:EquipmentResource:ParentNotFound";

        /// <summary>
        ///  设备资源的编号不能修改
        /// </summary>
        public const string NoImmutableCode = "Equipments:EquipmentResource:NoImmutable";
    }
}