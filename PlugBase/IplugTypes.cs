using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace PlugBase
{
    /// <summary>
    /// 插件必须继承该接口规范
    /// </summary>
    public interface IPlugBase
    {
        void Initialize(Grid plugsGrid);
        void Click(object sender, MouseButtonEventArgs e);
    }
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class AssemblyInfoAndCompanyInfoAttribute : System.Attribute
    {
        /// <summary>
        /// 程序集名称(不包括扩展名)
        /// </summary>
        public string AssemblyName { get; set; }
        /// <summary>
        /// 程序集版本
        /// </summary>
        public string AssemblyVersion { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// 菜单名(在承载的主程序中要显示的名称)
        /// </summary>
        public string MenuName { get; set; }

        public AssemblyInfoAndCompanyInfoAttribute()
        {

        }

    }
}
