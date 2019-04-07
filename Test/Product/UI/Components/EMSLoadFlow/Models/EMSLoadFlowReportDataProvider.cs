
//###############################################################
//														        #
//	This code was generated by a PowerFunctionsReportDSL tool.	#
//	Changes to this file may cause incorrect behavior	        #
//	and will be lost if the code is regenerated.		        #
//														        #
//###############################################################

using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using TelventDMS.Common.Platform.Logger;
using TelventDMS.Common.DMS.Common;
using TelventDMS.UI.Components.CompositeCommon;
using TelventDMS.UI.Components.CompositeCommon.Interfaces;
using TelventDMS.UI.Components.EMSLoadFlow.Properties;
using TelventDMS.UI.Components.EMSLoadFlow.View;
using TelventDMS.UI.Components.EMSLoadFlow.ViewModels;
using TelventDMS.UI.Resources;
using TelventDMS.UI.ServiceProxies;
using TelventDMS.UI.Components.CoreInterfaces.Interfaces;
using TelventDMS.Common.Platform.ETWPerformance;


namespace TelventDMS.UI.Components.EMSLoadFlow.Models
{
    public partial class EMSLoadFlowReportDataProvider
    {
        #region Fields

		private IJobManager jobManager;
		private string jobGuid;
		private EMSLoadFlowReportJob job;
		private EMSLoadFlowReportView reportView;
		private IElectricsProvider electricProvider;
		private bool isTabularViewActive;
		private GrayableWindowMessageHelper messageHelper;


        #endregion Fields

        #region Constructor

		public EMSLoadFlowReportDataProvider(EMSLoadFlowReportView reportView)
		{
			this.reportView = reportView;
			jobGuid = Guid.NewGuid().ToString();
			jobManager = ServiceLocator.Current.GetInstance<IJobManager>();
			job = new EMSLoadFlowReportJob();
			ReportParameter = new EMSLoadFlowReportJobParam();
			ReportParameter.HierarchyType = HierarchyType.Container;
			electricProvider = ServiceLocator.Current.GetInstance<IElectricsProvider>();
			ReportParameter.HierarchyNetworkType = HierarchyNetworkType.EMS;
			IsInitialized = false;
			messageHelper = new GrayableWindowMessageHelper("Please Wait", "EMSLoadFlow Report: EMSLoadFlowReportJob");
		}


        #endregion Constructor

        #region Properties

        public EMSLoadFlowReportJobParam ReportParameter { get; set; }

        public bool IsInitialized { get; set; }

        public EMSLoadFlowReportView ReportView
		{
			get
			{
				return reportView;
			}
		}

        public EMSLoadFlowReportJob Job
		{
			get
			{
				return job;
			}
		}

        public IJobManager JobManager
		{
			get
			{
				return jobManager;
			}
		}

        public bool IsTabularViewActive
		{
			get
			{
				return isTabularViewActive;
			}
		}

        #endregion Properties

        #region Methods

        public void Init()
		{
			IsInitialized = true;

			job.HierarchyType = ReportParameter.HierarchyType;
			job.ReportType = ReportParameter.ReportType;
			job.SelectedRecords = new List<long>();
			messageHelper.ShowMessage("EMSLoadFlow Report: EMSLoadFlowReportJob - Init");
			jobManager.StartAsyncJob(jobGuid, job, ResultHandler);
		}
    
        public void ProvideRecords(List<long> itemIds)
		{
			ReportParameter.SelectedRecords = itemIds;
			messageHelper.ShowMessage("EMSLoadFlow Report: EMSLoadFlowReportJob - ProvideRecords");
			jobManager.ModifyAsyncJob(jobGuid, ReportParameter);
		}

		public void Reset()
		{
			ReportParameter.SelectedRecords = new List<long>();
			messageHelper.ShowMessage("EMSLoadFlow Report: EMSLoadFlowReportJob - Reset");
			jobManager.ModifyAsyncJob(jobGuid, ReportParameter);
		}

		/// <summary>
		/// Refreshes report data
		/// </summary>
		public void Refresh()
		{
			messageHelper.ShowMessage("EMSLoadFlow Report: EMSLoadFlowReportJob - Refresh");
			jobManager.ModifyAsyncJob(jobGuid, new RefreshParam());
		}

		/// <summary>
		/// Terminate async job
		/// </summary>
		public void Terminate()
		{
			jobManager.TerminateAsyncJob(jobGuid);
			messageHelper.HideMessage();
		}

        public void ShowTabularView()
		{
			isTabularViewActive = true;
		}

		public void ShowHierarchyView()
		{
			isTabularViewActive = false;
		}

		protected internal void ResultHandler(JobResult result)
		{
			messageHelper.HideMessage();
			if (result is EMSLoadFlowReportResult)
			{
				EMSLoadFlowReportResult reportResult = (EMSLoadFlowReportResult)result;
				switch (reportResult.EMSLoadFlowReportType)
				{
					case EMSLoadFlowReportType.Node:
						{
							EMSLoadFlowNodeResults results = reportResult as EMSLoadFlowNodeResults;
							if (results != null && results.Records.Count != 0)
							{
								FillEMSLoadFlowNodeResults(results);
							}
							break;
						}
					case EMSLoadFlowReportType.NoResults:
						break;
					default:
						break;
				}
			}
		}

		internal void FillEMSLoadFlowNodeResults(EMSLoadFlowNodeResults result)
		{
			List<EMSLoadFlowNodeViewModel> records = new List<EMSLoadFlowNodeViewModel>();
			foreach (EMSLoadFlowNodeRecord record in result.Records)
			{
				records.Add(new EMSLoadFlowNodeViewModel(record, isTabularViewActive));
			}
			if (records.Count > 0)
			{
				byte minLevel = records.Min(rec => rec.DataGridTreeViewItemInfo.Level);
				if (minLevel > 0)
				{
					foreach (EMSLoadFlowNodeViewModel record in records)
					{
						record.DataGridTreeViewItemInfo.Level = (byte)(record.DataGridTreeViewItemInfo.Level - minLevel);
					}
				}
			}
			reportView.EMSLoadFlowNodeDataGrid.ItemsSource = records;
		}




        #endregion Methods

    }
}