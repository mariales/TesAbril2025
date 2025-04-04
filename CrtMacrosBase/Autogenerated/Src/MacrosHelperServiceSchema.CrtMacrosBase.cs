﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MacrosHelperServiceSchema

	/// <exclude/>
	public class MacrosHelperServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MacrosHelperServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MacrosHelperServiceSchema(MacrosHelperServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f11c38bc-163a-4783-b903-5b016339927b");
			Name = "MacrosHelperService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,25,219,110,219,54,244,217,5,246,15,132,246,34,3,134,3,236,49,137,93,180,105,210,121,107,154,192,78,155,135,96,24,104,233,216,225,70,73,30,73,165,245,130,252,251,14,47,146,40,155,150,157,108,40,186,167,152,135,231,126,167,146,211,12,228,138,38,64,110,64,8,42,139,133,26,158,21,249,130,45,75,65,21,43,242,31,94,61,254,240,170,87,74,150,47,201,108,45,21,100,39,27,231,225,12,196,3,75,224,178,72,129,119,94,14,111,97,222,141,240,38,81,236,193,200,221,194,155,150,185,98,25,104,124,70,57,251,59,140,117,86,112,14,137,190,146,195,247,144,35,110,210,224,248,38,102,153,79,237,223,8,216,5,31,158,163,10,138,129,12,35,120,94,27,126,82,140,7,209,208,5,29,210,155,219,202,47,211,162,84,136,179,101,168,198,156,129,148,40,108,166,168,210,58,35,202,143,2,150,8,33,103,156,74,121,76,46,105,34,10,249,51,240,21,8,199,207,160,221,185,3,234,172,4,77,212,111,26,246,14,22,180,228,202,147,11,6,62,147,171,45,216,27,185,250,8,10,53,93,161,185,115,198,153,90,79,225,175,146,9,200,32,87,50,246,15,58,178,100,68,246,144,104,172,161,3,164,125,45,100,85,206,57,75,72,162,77,9,89,66,142,201,91,42,193,157,6,100,50,5,154,94,229,124,237,187,5,249,60,26,147,107,215,92,48,224,41,250,230,90,232,76,179,254,232,29,29,29,145,83,89,102,25,21,235,113,5,152,228,82,209,28,5,21,11,188,4,32,137,128,197,40,242,85,249,252,83,116,52,38,106,189,130,97,205,230,200,231,179,178,82,136,64,221,10,212,141,180,169,201,239,153,119,62,113,154,66,158,90,101,219,154,99,180,164,18,101,162,10,161,245,55,238,233,80,255,12,101,42,144,132,237,55,195,249,112,159,45,54,32,1,194,184,79,116,151,232,245,90,230,96,208,115,248,66,222,243,98,78,185,79,21,247,117,58,247,158,190,165,242,6,178,162,130,102,36,199,158,55,138,124,77,163,177,101,72,238,205,113,120,122,100,48,195,132,165,4,129,161,200,109,155,137,198,159,240,76,146,26,208,34,238,112,217,70,34,248,234,12,200,167,150,12,210,22,185,203,217,27,169,132,24,27,108,70,27,140,252,40,236,74,186,107,81,32,59,221,244,14,43,25,236,143,186,59,99,232,116,236,119,133,239,3,205,151,186,249,96,229,95,80,157,208,107,12,95,119,5,5,104,176,122,248,22,240,196,247,123,128,38,4,179,254,92,130,34,163,113,144,41,121,253,154,196,193,11,155,227,1,166,113,219,249,125,155,243,61,217,33,100,68,30,40,47,161,9,75,87,96,46,65,221,23,182,145,21,10,101,64,106,239,239,174,230,178,224,160,32,142,44,10,97,146,164,176,18,144,160,27,211,129,206,1,19,23,236,72,27,221,8,39,166,178,144,55,98,89,154,182,60,140,76,47,198,40,56,33,228,129,9,85,82,78,222,49,99,23,134,233,244,125,201,144,239,213,252,15,196,24,147,109,38,49,182,45,61,186,64,143,207,245,71,172,162,1,209,52,216,21,147,66,164,147,116,96,92,211,251,192,164,58,181,180,147,124,81,140,93,70,235,223,178,74,122,1,170,20,121,187,111,6,244,142,125,89,181,152,22,67,63,251,255,141,211,38,242,172,20,2,229,233,128,219,187,243,175,104,73,135,239,230,69,193,201,78,186,248,197,126,216,205,114,151,225,193,42,70,119,74,130,90,39,56,72,81,107,92,55,86,28,221,112,104,103,173,240,223,22,233,58,26,223,184,19,26,157,174,187,59,107,69,56,43,77,42,121,180,210,66,186,201,109,200,103,201,61,100,84,7,62,26,155,125,109,77,164,1,25,172,67,56,76,210,154,210,102,14,97,169,190,89,176,125,163,65,215,116,73,151,160,57,124,112,191,59,137,109,20,229,248,122,203,217,248,227,43,218,219,57,242,166,184,186,227,78,160,71,223,233,81,197,170,157,113,29,84,58,204,213,239,91,166,238,167,128,130,19,72,13,9,106,83,85,173,31,78,91,168,27,23,46,92,3,210,42,243,38,14,174,216,43,231,186,99,227,43,236,123,169,221,61,99,125,211,175,82,188,75,119,81,253,112,253,119,55,170,91,54,122,85,57,96,195,77,33,109,198,26,129,109,16,50,45,57,183,116,170,158,15,61,182,208,67,192,31,186,216,37,182,215,27,178,220,2,85,38,89,30,141,233,88,177,31,11,117,158,173,212,58,238,55,72,189,176,78,181,161,1,43,30,201,7,223,161,158,119,159,78,28,215,39,247,183,242,221,240,6,197,212,37,54,10,168,173,27,171,143,20,183,114,97,59,208,181,250,117,168,183,13,233,159,108,170,225,242,103,175,38,215,156,178,60,168,78,157,129,255,153,70,137,46,71,212,4,247,109,247,180,210,14,36,192,49,229,30,247,248,113,107,54,61,199,133,117,153,28,226,167,195,36,237,246,78,167,176,13,23,52,25,244,68,112,40,38,247,36,62,255,154,192,202,108,150,80,231,110,205,160,185,28,145,138,62,192,125,65,209,165,246,250,201,31,108,21,234,33,59,106,179,10,237,123,19,77,109,147,108,119,89,242,229,30,4,184,33,139,165,36,92,35,36,243,53,81,247,192,132,93,203,228,161,243,79,224,43,22,36,142,175,234,161,234,0,187,219,127,221,214,240,25,161,48,201,181,14,18,251,161,85,15,119,231,122,4,183,251,252,221,21,198,221,124,112,240,95,242,189,187,91,152,79,242,135,226,79,124,101,216,109,102,68,162,235,171,217,77,132,47,11,193,188,4,138,76,206,216,35,94,234,156,156,169,53,215,87,200,227,18,67,132,61,164,134,14,111,5,93,173,192,173,107,83,107,213,69,33,50,170,90,4,22,52,252,69,22,249,128,84,182,117,227,185,77,105,231,115,201,31,90,117,130,7,241,140,82,149,203,171,180,124,160,194,248,210,51,189,10,138,95,50,186,29,99,227,191,18,174,35,147,215,110,166,13,13,128,28,7,169,78,252,188,221,55,84,125,45,6,45,238,131,154,249,121,107,119,245,97,85,165,118,109,111,85,142,103,152,64,140,51,61,7,248,247,159,240,45,109,191,97,246,95,106,185,213,232,244,163,250,191,41,135,157,22,60,163,62,38,238,37,250,43,83,38,36,238,231,40,244,176,213,115,166,65,143,67,73,27,157,103,148,241,218,147,110,186,184,157,26,252,59,20,209,200,243,56,199,77,161,89,68,61,186,195,181,176,185,142,234,248,232,153,227,139,49,179,113,141,177,58,43,120,153,229,159,117,122,159,90,186,113,28,153,135,74,152,153,155,157,207,227,87,189,95,28,75,189,242,181,63,6,104,242,137,188,0,138,201,12,231,57,157,115,72,227,8,113,220,43,54,77,153,121,91,243,107,93,62,248,44,21,50,234,123,35,246,192,78,227,47,26,91,203,64,32,110,245,14,208,118,243,224,0,219,245,226,142,150,55,59,104,84,125,240,120,122,94,119,124,174,206,221,13,114,99,99,176,208,13,224,254,111,230,174,104,236,167,243,119,84,81,191,223,236,251,76,93,19,247,30,119,182,108,87,25,222,75,49,220,121,141,240,75,200,230,32,98,109,189,238,97,245,155,181,213,51,204,19,171,114,73,243,125,171,254,6,181,119,138,56,149,116,131,127,174,46,230,237,221,210,198,21,85,19,182,151,104,116,179,57,13,14,215,203,31,186,65,205,90,27,252,139,116,115,180,47,10,161,170,123,92,32,136,77,3,236,80,236,229,153,109,139,241,165,169,237,166,208,49,105,253,247,107,139,121,71,234,127,207,81,173,154,255,203,212,147,237,231,90,80,195,205,39,221,179,34,140,144,127,0,50,138,163,179,191,29,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f11c38bc-163a-4783-b903-5b016339927b"));
		}

		#endregion

	}

	#endregion

}

