using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public static class Resources
	{
		private const string tab1 = "\t";
		private const string tab2 = "\t\t";
		private const string tab3 = "\t\t\t";
		private const string tab4 = "\t\t\t\t";
		private const string tab5 = "\t\t\t\t\t";
		private const string tab6 = "\t\t\t\t\t\t";
		private const string tab7 = "\t\t\t\t\t\t\t";
		private const string tab8 = "\t\t\t\t\t\t\t\t";
		private const string tab9 = "\t\t\t\t\t\t\t\t\t";
		private const string tab10 = "\t\t\t\t\t\t\t\t\t";
		private const string tab11 = "\t\t\t\t\t\t\t\t\t\t";

		static Resources()
		{
		}

		public static string Tab1
		{
			get { return tab1; }
		}
		public static string Tab2
		{
			get { return tab2; }
		}
		public static string Tab3
		{
			get { return tab3; }
		}
		public static string Tab4
		{
			get { return tab4; }
		}
		public static string Tab5
		{
			get { return tab5; }
		}
		public static string Tab6
		{
			get { return tab6; }
		}
		public static string Tab7
		{
			get { return tab7; }
		}
		public static string Tab8
		{
			get { return tab8; }
		}
		public static string Tab9
		{
			get { return tab9; }
		}
		public static string Tab10
		{
			get { return tab10; }
		}
		public static string Tab11
		{
			get { return tab11; }
		}

		public static string DetailsElementGid
		{
			get
			{
				StringBuilder sb = new StringBuilder();

				sb.AppendLine(Resources.Tab2 + "public long DetailsElementGid");
				sb.AppendLine(Resources.Tab2 + "{");
				sb.AppendLine(Resources.Tab3 + "get { return DataGridTreeViewItemInfo.Lid; }");
				sb.AppendLine(Resources.Tab2 + "}");

				return sb.ToString();
			}
		}

		public static string DataGridTreeViewItemInfo
		{
			get
			{
				StringBuilder sb = new StringBuilder();

				sb.AppendLine(Resources.Tab2 + "public HierarchicalReportRecord DataGridTreeViewItemInfo { get; set; }");

				return sb.ToString();
			}
		}

		public static string Title
		{
			get
			{
				StringBuilder sb = new StringBuilder();

				sb.AppendLine(Resources.Tab2 + "public string Title");
				sb.AppendLine(Resources.Tab2 + "{");
				sb.AppendLine(Resources.Tab3 + "get");
				sb.AppendLine(Resources.Tab3 + "{");
				sb.AppendLine(Resources.Tab4 + "if (DataGridTreeViewItemInfo != null)");
				sb.AppendLine(Resources.Tab4 + "{");
				sb.AppendLine(Resources.Tab5 + "return DataGridTreeViewItemInfo.Title;");
				sb.AppendLine(Resources.Tab4 + "}");
				sb.AppendLine(Resources.Tab4 + "return string.Empty;");
				sb.AppendLine(Resources.Tab3 + "}");
				sb.AppendLine(Resources.Tab2 + "}");

				return sb.ToString();
			}
		}

		public static string TabularViewIsActive
		{
			get
			{
				StringBuilder sb = new StringBuilder();

				sb.AppendLine(Resources.Tab2 + "public bool TabularViewIsActive");
				sb.AppendLine(Resources.Tab2 + "{");
				sb.AppendLine(Resources.Tab3 + "get");
				sb.AppendLine(Resources.Tab3 + "{");
				sb.AppendLine(Resources.Tab4 + "return tabularViewIsActive;");
				sb.AppendLine(Resources.Tab3 + "}");
				sb.AppendLine(Resources.Tab3 + "set");
				sb.AppendLine(Resources.Tab3 + "{");
				sb.AppendLine(Resources.Tab4 + "tabularViewIsActive = value;");
				sb.AppendLine(Resources.Tab4 + "OnPropertyChanged(\"TabularViewIsActive\");");
				sb.AppendLine(Resources.Tab3 + "}");
				sb.AppendLine(Resources.Tab2 + "}");

				return sb.ToString();
			}
		}

		public static string RowIsNotVisible
		{
			get
			{
				StringBuilder sb = new StringBuilder();

				sb.AppendLine(Resources.Tab2 + "public bool RowIsNotVisible");
				sb.AppendLine(Resources.Tab2 + "{");
				sb.AppendLine(Resources.Tab3 + "get");
				sb.AppendLine(Resources.Tab3 + "{");
				sb.AppendLine(Resources.Tab4 + "return rowIsNotVisible;");
				sb.AppendLine(Resources.Tab3 + "}");
				sb.AppendLine(Resources.Tab3 + "set");
				sb.AppendLine(Resources.Tab3 + "{");
				sb.AppendLine(Resources.Tab4 + "rowIsNotVisible = value;");
				sb.AppendLine(Resources.Tab4 + "OnPropertyChanged(\"RowIsNotVisible\");");
				sb.AppendLine(Resources.Tab3 + "}");
				sb.AppendLine(Resources.Tab2 + "}");

				return sb.ToString();
			}
		}

		public static string RecordType
		{
			get
			{
				StringBuilder sb = new StringBuilder();

				sb.AppendLine(Resources.Tab2 + "public DMSType RecordType");
				sb.AppendLine(Resources.Tab2 + "{");
				sb.AppendLine(Resources.Tab3 + "get");
				sb.AppendLine(Resources.Tab3 + "{");
				sb.AppendLine(Resources.Tab4 + "return recordType;");
				sb.AppendLine(Resources.Tab3 + "}");
				sb.AppendLine(Resources.Tab3 + "set");
				sb.AppendLine(Resources.Tab3 + "{");
				sb.AppendLine(Resources.Tab4 + "recordType = value;");
				sb.AppendLine(Resources.Tab3 + "}");
				sb.AppendLine(Resources.Tab2 + "}");

				return sb.ToString();
			}
		}

		public static string GetReportRecordFor(DataGrid model)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "public " + model.Name + "Record ReportRecord");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab3 + "get");
			sb.AppendLine(Resources.Tab3 + "{");
			sb.AppendLine(Resources.Tab4 + "return reportRecord;");
			sb.AppendLine(Resources.Tab3 + "}");
			sb.AppendLine(Resources.Tab3 + "set");
			sb.AppendLine(Resources.Tab3 + "{");
			sb.AppendLine(Resources.Tab4 + "reportRecord = value;");
			sb.AppendLine(Resources.Tab3 + "}");
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}
	}
}
