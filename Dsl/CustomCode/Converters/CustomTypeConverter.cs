using Microsoft.VisualStudio.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Converters
{
	public class CustomTypeConverter : System.ComponentModel.TypeConverter
	{
		/// <summary>
		/// Return true to indicate that we return a list of values to choose from
		/// </summary>
		/// <param name="context"></param>
		public override bool GetStandardValuesSupported
		  (System.ComponentModel.ITypeDescriptorContext context)
		{
			return true;
		}

		/// <summary>
		/// Returns true to indicate that the user has
		/// to select a value from the list
		/// </summary>
		/// <param name="context"></param>
		/// <returns>If we returned false, the user would
		/// be able to either select a value from
		/// the list or type in a value that is not in the list.</returns>
		public override bool GetStandardValuesExclusive
			(System.ComponentModel.ITypeDescriptorContext context)
		{
			return true;
		}

		/// <summary>
		/// Return a list of the values to display in the grid
		/// </summary>
		/// <param name="context"></param>
		/// <returns>A list of values the user can choose from</returns>
		public override StandardValuesCollection GetStandardValues
			(System.ComponentModel.ITypeDescriptorContext context)
		{
			// Try to get a store from the current context
			// "context.Instance"  returns the element(s) that
			// are currently selected i.e. whose values are being
			// shown in the property grid.
			// Note that the user could have selected multiple objects,
			// in which case context.Instance will be an array.
			Store store = GetStore(context.Instance);

			ColumnAttribute attr = (ColumnAttribute)context.Instance;

			ModelRoot root = attr.DataGrid.ModelRoot;

			List<string> values = new List<string>();

			values.AddRange(System.Enum.GetNames(typeof(Types)));

			if (store != null)
			{
				foreach (ModelType type in root.Types)
				{
					if(type is Enum)
					{
						Enum typeEnum =  type as Enum;
						values.Add(typeEnum.Name);
					}
				}

			}

			values.Add("");
			return new StandardValuesCollection(values);
		}

		/// <summary>
		/// Attempts to get to a store from the currently selected object(s)
		/// in the property grid.
		/// </summary>
		private Store GetStore(object gridSelection)
		{
			// We assume that "instance" will either be a single model element, or
			// an array of model elements (if multiple items are selected).

			ColumnAttribute currentElement = null;

			object[] objects = gridSelection as object[];
			if (objects != null && objects.Length > 0)
			{
				currentElement = objects[0] as ColumnAttribute;
			}
			else
			{
				currentElement = gridSelection as ColumnAttribute;
			}

			return (currentElement == null) ? null : currentElement.Store;
		}
	}
}
