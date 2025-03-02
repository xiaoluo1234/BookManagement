namespace BookManagement.EquipmentTypes;
public class EquipmentTypeEdto
{
    /// <summary>
    /// 编码
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// 名称
    /// </summary>
    public string DisplayText { get; set; }

    /// <summary>
    /// 是否静态
    /// </summary>
    public bool IsStatic { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int Rank { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string Remark { get; set; }
}
