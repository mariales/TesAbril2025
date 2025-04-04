﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TimeSlotProviderSchema

	/// <exclude/>
	public class TimeSlotProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TimeSlotProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TimeSlotProviderSchema(TimeSlotProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5437dbcf-05da-4b65-b75c-2a6e91f2e7a6");
			Name = "TimeSlotProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("139fe86f-8a0e-494b-a137-370fb60ffc8b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,25,107,111,227,54,242,179,11,244,63,176,46,80,200,168,35,59,87,160,216,110,108,31,242,220,250,176,219,4,155,108,23,184,195,97,65,75,244,70,136,68,186,36,149,212,183,205,127,191,25,62,36,74,150,19,59,11,28,238,147,69,114,94,156,25,206,203,156,22,76,173,104,194,200,13,147,146,42,177,212,241,169,224,203,236,115,41,169,206,4,143,79,165,190,146,34,45,19,157,221,103,122,125,42,86,89,46,244,183,223,124,249,246,155,94,169,50,254,153,92,175,149,102,197,81,107,13,100,242,156,37,72,67,197,111,24,103,50,75,54,96,206,168,166,27,155,111,51,254,71,189,25,202,85,20,130,119,159,72,182,109,63,62,59,129,35,56,252,94,178,207,32,12,57,205,169,82,175,201,77,86,176,107,115,19,56,91,149,139,60,75,72,130,71,213,9,249,98,206,42,196,139,140,229,41,96,94,25,96,123,54,26,141,200,68,149,69,65,229,122,230,55,144,0,81,72,65,105,42,53,209,176,142,43,232,81,8,238,24,131,30,152,197,66,132,163,157,104,51,158,238,67,25,192,29,221,239,225,211,94,169,121,191,119,76,223,138,157,46,120,122,203,146,59,69,50,69,38,43,42,105,33,217,146,112,240,164,105,31,37,235,143,102,68,220,51,153,211,149,34,73,41,37,227,218,136,188,69,82,179,99,232,132,68,102,19,197,24,73,128,244,180,239,45,130,148,51,14,58,226,9,139,39,35,131,83,147,144,76,151,146,171,217,36,153,221,200,146,77,70,9,64,47,247,20,145,188,55,84,8,16,89,210,92,89,42,66,223,50,249,144,41,100,234,185,4,58,94,8,145,147,185,186,180,4,193,5,163,202,133,144,230,0,29,169,215,235,89,76,231,19,19,203,206,46,126,248,193,88,115,54,13,55,255,250,203,96,245,236,170,121,6,8,13,50,136,221,132,159,182,225,17,196,111,90,95,232,245,30,59,29,194,238,182,54,183,188,30,8,13,247,89,202,164,129,105,251,10,174,29,128,34,199,87,115,162,5,81,140,202,228,150,44,133,36,75,9,6,214,222,159,193,157,56,73,4,215,52,129,111,149,220,178,180,204,153,140,61,221,208,101,58,159,107,45,74,111,219,195,149,217,61,60,7,123,184,178,11,242,65,49,9,17,143,219,80,69,62,149,201,81,19,32,3,215,248,100,212,8,150,253,40,228,29,252,252,42,74,73,166,228,85,23,40,232,109,3,240,176,13,57,63,231,101,193,36,93,228,108,114,70,215,151,203,143,140,221,205,200,167,7,248,57,231,41,108,41,64,227,236,225,95,255,38,95,72,5,17,95,83,240,161,148,174,135,225,94,201,97,135,60,182,88,188,41,179,20,164,41,104,150,223,172,87,108,14,230,55,123,241,21,149,138,69,125,246,183,87,63,29,166,44,57,72,150,201,248,32,93,30,30,30,44,198,227,229,193,120,124,152,254,60,102,191,252,244,42,249,185,63,120,38,102,128,230,148,150,144,28,132,220,37,112,196,8,184,107,24,40,147,70,16,104,26,106,107,40,112,190,209,246,138,168,101,231,50,241,207,18,44,14,154,49,102,223,246,34,58,66,100,151,43,189,205,148,158,120,198,51,242,134,233,203,229,18,61,64,225,134,138,170,88,188,148,162,24,214,161,89,11,47,203,61,149,68,50,85,230,218,90,191,69,50,26,28,85,96,96,114,53,231,87,144,86,5,90,54,210,2,179,41,35,7,134,186,249,30,196,55,66,211,28,157,169,198,115,209,206,192,78,107,88,11,128,207,50,66,168,12,206,198,71,240,51,153,54,56,193,214,143,63,122,105,123,16,93,163,208,101,177,116,208,20,204,18,5,92,226,202,83,7,21,98,207,94,50,62,78,211,8,175,233,111,24,213,16,62,142,133,2,195,125,62,240,12,194,172,162,57,162,68,131,161,135,54,225,173,1,11,180,81,166,232,112,176,29,237,209,41,180,247,72,24,4,251,255,177,120,198,53,162,174,216,178,139,200,47,21,178,102,188,17,169,158,96,251,213,10,182,63,77,239,235,166,102,49,30,195,156,105,175,26,190,208,237,111,238,212,229,144,119,140,161,86,159,125,123,195,70,48,198,8,57,243,121,104,158,170,61,95,38,190,136,26,57,158,171,223,202,60,191,148,231,197,74,175,163,218,255,55,175,229,238,139,108,20,195,186,217,177,185,54,139,8,130,212,192,169,20,11,235,178,224,81,255,26,141,139,23,233,111,28,157,149,44,60,136,47,224,210,81,255,216,213,240,53,252,28,226,161,252,135,200,120,125,120,133,206,152,100,43,202,117,127,16,95,110,57,25,146,106,123,158,2,220,92,157,255,81,210,60,224,1,16,120,226,4,248,8,5,20,107,158,218,164,100,112,127,19,218,162,91,249,99,147,85,162,48,119,13,42,145,143,121,26,249,69,47,190,92,49,126,146,139,228,110,171,152,115,14,155,236,61,116,57,64,244,105,134,199,85,143,3,43,21,7,132,60,250,25,75,242,140,179,52,16,8,100,144,123,50,7,151,136,106,147,229,66,49,123,133,198,29,183,145,12,150,150,30,247,151,184,194,28,200,52,188,194,192,5,159,87,92,181,215,208,102,224,92,32,242,27,201,224,83,130,35,135,90,171,24,70,248,168,106,141,248,27,52,105,188,101,74,109,37,0,41,48,144,163,67,39,86,207,221,178,86,222,254,98,73,67,10,255,31,114,54,24,237,175,207,214,53,59,37,109,108,18,170,92,172,177,225,200,182,210,209,217,201,249,159,44,41,161,106,35,233,162,250,156,98,153,28,159,115,85,74,118,118,82,87,85,65,132,115,248,115,236,240,223,51,10,21,24,68,59,243,51,117,1,46,182,228,152,61,141,106,242,65,153,240,112,155,229,140,68,22,51,70,200,128,197,78,25,176,74,129,142,134,73,16,168,172,223,105,94,98,237,109,243,192,172,161,221,42,233,185,172,247,44,110,43,222,134,89,250,49,204,127,47,75,106,239,89,1,205,234,73,169,214,230,118,97,186,170,129,176,155,50,169,110,88,15,48,22,14,101,207,36,6,85,32,163,208,164,153,74,208,211,197,246,172,226,209,168,0,253,110,220,104,129,43,222,181,49,26,192,190,127,245,112,118,227,121,227,118,152,182,73,179,109,188,38,131,173,6,106,74,103,218,241,26,21,150,47,146,44,36,208,150,43,228,181,221,109,182,214,165,30,189,89,96,237,232,96,102,98,1,94,156,165,176,178,149,253,14,221,137,35,139,231,228,59,112,32,200,99,56,89,240,107,143,17,191,203,236,11,233,62,164,127,250,67,43,184,22,33,49,187,234,36,213,62,106,19,50,172,38,0,182,95,39,247,236,176,203,68,106,101,199,21,213,164,194,204,45,86,70,115,67,8,104,240,214,214,27,147,38,20,8,251,84,10,246,110,159,105,129,39,247,120,1,101,166,33,205,22,184,6,172,83,57,34,248,1,73,213,67,87,243,64,69,244,45,213,0,80,114,248,166,94,94,19,106,89,106,54,68,158,139,7,245,186,226,148,195,235,39,26,234,171,105,127,1,234,103,186,95,55,226,80,182,20,179,73,202,84,34,179,21,198,246,89,53,169,33,69,9,120,11,28,119,144,7,219,60,144,91,236,40,72,244,234,245,120,140,118,58,196,143,193,144,188,19,102,52,1,59,23,50,195,175,140,39,121,137,93,199,100,20,210,158,140,12,191,167,184,99,1,137,19,71,46,72,225,42,123,178,202,41,164,158,212,232,143,242,53,17,155,211,190,166,250,64,65,70,75,120,151,125,37,72,93,237,87,179,111,234,250,105,122,35,84,118,176,124,114,242,97,28,103,102,18,18,193,23,106,189,173,154,153,217,209,178,25,164,109,78,65,67,58,224,100,51,104,205,191,138,70,160,192,153,111,173,72,150,66,219,150,45,51,168,53,135,134,38,36,106,156,234,181,38,122,15,25,60,234,5,115,124,88,186,125,102,123,209,194,68,109,13,205,68,208,13,103,75,5,165,3,2,252,71,240,246,24,214,81,2,125,222,169,217,254,143,208,75,121,239,226,161,245,39,179,10,159,121,245,228,230,75,239,108,250,22,28,114,85,149,221,47,125,89,28,76,177,162,74,177,116,95,159,180,88,232,129,85,184,134,136,57,130,208,104,67,203,190,244,182,41,239,179,173,86,9,232,133,97,193,217,173,201,125,94,0,188,103,30,134,84,55,23,54,182,64,125,44,140,218,193,16,133,113,27,111,221,96,194,215,93,6,65,141,118,225,171,148,175,110,250,177,36,248,174,149,38,45,41,44,207,91,205,252,246,122,170,110,237,17,249,131,78,252,224,109,99,108,82,143,233,180,176,112,90,60,5,245,100,49,231,229,235,172,81,234,218,201,72,228,139,19,91,154,24,230,195,70,93,209,81,25,138,96,184,137,79,117,99,222,217,165,42,39,111,171,164,181,251,195,6,201,134,242,26,140,93,0,14,248,118,207,124,252,221,220,125,66,3,239,44,81,192,107,195,154,24,28,254,9,225,200,245,67,167,54,84,225,160,57,190,113,71,71,97,225,84,195,79,137,7,152,243,165,136,65,58,43,205,223,157,69,237,234,181,91,197,110,8,84,149,226,211,25,121,210,168,13,226,160,27,112,30,141,123,23,86,33,173,34,124,88,9,54,104,186,193,206,100,176,186,221,32,226,106,217,221,255,99,130,189,255,2,104,254,224,9,143,30,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5437dbcf-05da-4b65-b75c-2a6e91f2e7a6"));
		}

		#endregion

	}

	#endregion

}

