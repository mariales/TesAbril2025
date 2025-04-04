﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DownloadFileNameEncoderSchema

	/// <exclude/>
	public class DownloadFileNameEncoderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DownloadFileNameEncoderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DownloadFileNameEncoderSchema(DownloadFileNameEncoderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d2e4a417-bed4-4ca1-aecc-9d38946ec431");
			Name = "DownloadFileNameEncoder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,203,110,211,64,20,93,7,137,127,24,76,161,78,155,56,44,161,121,180,85,154,150,74,60,170,54,17,18,77,91,77,237,235,100,36,219,99,102,198,105,67,148,46,248,21,22,44,224,15,16,155,124,10,95,194,181,199,118,222,208,74,108,18,251,206,185,231,158,251,26,7,212,7,25,82,27,72,27,132,160,146,187,202,106,242,192,101,189,72,80,197,120,64,70,143,31,21,34,201,130,30,57,27,74,5,126,117,225,221,106,195,173,178,78,161,23,121,84,180,110,67,1,82,162,159,156,226,166,204,31,224,218,122,173,84,104,237,95,75,37,168,173,230,129,241,81,71,49,143,169,33,169,103,244,153,79,122,128,104,196,63,21,208,139,197,53,61,42,229,14,57,224,55,129,199,169,115,200,60,120,135,25,181,2,155,59,32,18,104,24,93,123,204,38,118,140,92,7,140,147,68,104,78,123,200,192,115,144,247,68,112,5,182,2,71,31,135,217,107,162,20,203,164,48,117,210,140,132,128,64,165,175,213,148,9,2,71,147,205,51,35,10,51,143,108,197,5,210,39,210,82,110,45,115,141,64,115,54,96,127,250,92,76,218,83,40,204,107,192,226,205,96,226,250,22,198,127,151,245,22,84,159,175,200,184,82,169,144,154,140,124,159,138,97,35,51,156,130,207,7,64,100,8,54,163,30,177,251,52,110,37,8,73,92,193,125,226,166,210,173,156,160,178,200,80,11,209,197,39,1,162,234,70,134,55,26,113,210,137,209,170,85,18,196,212,65,128,138,68,32,167,16,114,195,80,114,164,86,200,64,239,12,62,223,53,172,124,60,102,90,255,153,246,107,230,110,102,122,156,233,201,106,171,185,208,171,7,183,56,231,161,135,219,98,102,160,18,217,51,206,47,105,249,243,126,249,99,55,28,29,203,230,80,48,15,59,57,126,81,126,117,101,149,46,159,239,77,190,110,252,254,242,227,201,228,215,228,219,221,102,221,44,118,207,187,23,163,49,153,124,159,252,172,53,238,158,110,61,219,46,95,108,27,165,36,86,193,184,50,74,58,212,251,48,217,14,220,70,63,196,96,78,241,97,125,156,25,173,149,77,60,2,37,9,238,106,136,49,128,216,241,168,4,138,56,12,13,146,37,139,223,7,26,175,198,128,122,209,255,237,229,172,67,36,161,35,188,19,170,250,122,210,141,6,233,160,158,57,27,113,185,32,144,62,102,180,107,39,164,249,175,84,22,166,67,239,221,128,9,21,225,20,165,51,112,4,1,224,253,151,228,178,56,23,37,114,205,185,71,22,149,227,210,185,212,147,249,216,164,94,56,125,54,222,136,144,111,116,210,198,66,188,207,167,240,41,2,169,176,11,250,191,190,112,149,88,41,160,58,203,135,97,197,126,47,78,176,78,204,212,211,234,228,198,221,221,52,5,171,229,135,106,88,180,218,252,13,191,1,113,28,12,168,96,52,80,102,113,142,78,151,53,23,135,164,75,121,237,98,55,152,213,146,54,13,225,128,42,122,150,120,154,211,53,217,153,189,184,45,116,214,142,83,132,142,200,92,98,230,234,227,143,140,162,44,144,166,65,113,148,57,115,140,98,86,185,194,82,205,80,214,70,50,91,201,208,116,141,209,186,21,206,67,142,187,134,161,195,142,147,95,192,206,144,117,10,36,117,177,56,247,22,176,85,239,180,15,203,47,55,55,71,11,213,27,47,135,188,119,70,153,114,20,94,37,15,140,148,222,80,27,6,85,138,218,125,31,179,171,146,209,82,204,212,105,245,21,162,173,179,70,180,252,1,113,1,238,73,30,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d2e4a417-bed4-4ca1-aecc-9d38946ec431"));
		}

		#endregion

	}

	#endregion

}

