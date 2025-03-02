using System;
using Volo.Abp;
using Volo.Abp.Caching;
using Volo.Abp.Domain.Entities;

namespace BookManagement.EquipmentTypes
{
    /// <summary>
    /// 设备类型
    /// </summary>
    [CacheName(nameof(EquipmentType))]
    public class EquipmentType : Entity<Guid>
    {
        #region Prop

        /// <summary>
        /// 编码
        /// </summary>
        public string? Code { get; private set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        public string? DisplayText { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsStatic { get; private set; }

        /// <summary>
        /// 顺序值
        /// </summary>
        public int Rank { get; private set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string? Remark { get; private set; }

        #endregion

        #region Ctor

        /// <summary>
        /// 设备类型
        /// </summary>
        protected EquipmentType()
        {
        }

        /// <summary>
        /// 设备类型
        /// </summary>
        /// <param name="code">编码</param>
        /// <param name="displayText">显示名称</param>
        /// <param name="isStatic"></param>
        /// <param name="rank">顺序值</param>
        /// <param name="remark">描述</param>
        /// <returns>设备类型实例</returns>
        public EquipmentType(
            Guid id,
            bool isStatic,
            int rank,
            string? code = null,
            string? displayText = null,
            string? remark = null
        ) : base(id)
        {

            SetCode(code)
            .SetDisplayText(displayText)
            .SetIsStatic(isStatic)
            .SetRank(rank)
            .SetRemark(remark);
        }

        #endregion

        #region Method


        /// <summary>
        /// 设置编码
        /// </summary>
        /// <param name="code">编码</param>
        /// <returns>设备类型实例</returns>
        public EquipmentType SetCode(string? code)
        {
            Code = Check.Length(code, nameof(code), EquipmentTypeConstants.MaxLength.Code);
            return this;
        }

        /// <summary>
        /// 设置显示名称
        /// </summary>
        /// <param name="displayText">显示名称</param>
        /// <returns>设备类型实例</returns>
        public EquipmentType SetDisplayText(string? displayText)
        {
            DisplayText = Check.Length(displayText, nameof(displayText), EquipmentTypeConstants.MaxLength.DisplayText);
            return this;
        }

        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="isStatic"></param>
        /// <returns>设备类型实例</returns>
        public EquipmentType SetIsStatic(bool isStatic)
        {
            IsStatic = isStatic;
            return this;
        }

        /// <summary>
        /// 设置顺序值
        /// </summary>
        /// <param name="rank">顺序值</param>
        /// <returns>设备类型实例</returns>
        public EquipmentType SetRank(int rank)
        {
            Rank = rank;
            return this;
        }

        /// <summary>
        /// 设置描述
        /// </summary>
        /// <param name="remark">描述</param>
        /// <returns>设备类型实例</returns>
        public EquipmentType SetRemark(string? remark)
        {
            Remark = Check.Length(remark, nameof(remark), EquipmentTypeConstants.MaxLength.Remark);
            return this;
        }

        #endregion
    }

}
