﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CopilotPromptFactorySchema

	/// <exclude/>
	public class CopilotPromptFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CopilotPromptFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CopilotPromptFactorySchema(CopilotPromptFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a20b2ceb-a143-40d1-89d2-167034a45c75");
			Name = "CopilotPromptFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ed753793-30d5-4797-a3f9-3019dcc6e358");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,90,91,111,220,184,21,126,158,5,246,63,176,78,177,182,23,19,5,237,163,157,4,112,236,92,220,230,214,216,217,69,155,4,89,142,196,153,225,90,67,106,69,201,246,36,240,127,239,119,14,73,73,51,35,121,220,110,138,162,64,243,224,140,196,195,115,191,82,52,114,161,92,33,83,37,142,75,37,43,109,147,99,91,232,220,86,223,127,247,245,251,239,70,181,211,102,38,206,150,174,82,139,195,181,103,64,230,185,74,177,199,184,228,185,50,170,212,233,6,204,185,186,174,218,151,231,170,44,165,179,211,10,123,75,149,60,147,105,101,75,173,28,32,0,115,175,84,51,32,19,79,77,189,56,8,8,222,150,118,81,84,231,178,156,169,138,129,180,169,84,105,100,46,20,160,122,129,70,196,248,232,120,46,43,241,72,252,105,76,15,71,133,198,239,63,211,239,27,79,74,153,204,83,91,161,124,74,200,167,208,198,129,56,13,122,240,184,61,167,203,85,14,116,132,30,2,246,156,60,120,240,64,60,116,245,98,33,203,229,227,248,130,181,173,156,144,194,177,8,162,224,173,98,106,75,81,205,149,112,133,74,245,84,171,76,84,44,86,210,96,122,176,142,234,97,33,75,185,16,6,150,124,180,227,161,119,30,159,3,135,255,45,236,212,99,236,210,73,30,62,224,93,253,72,108,193,70,245,88,2,99,169,119,15,35,194,226,38,134,82,85,117,105,28,111,90,39,22,215,26,96,117,157,42,70,68,136,167,143,118,142,202,89,189,80,166,122,26,223,239,60,62,50,162,54,174,46,10,91,86,141,30,68,169,82,165,47,85,6,164,13,14,70,235,170,146,92,204,43,182,235,23,123,155,78,18,144,141,3,180,95,122,227,5,139,2,194,97,76,157,231,251,135,219,156,230,56,151,206,29,244,161,98,176,117,243,211,115,36,69,214,246,138,5,231,107,174,144,196,189,15,214,54,67,209,120,188,112,241,249,196,10,99,43,177,176,153,158,46,217,212,81,2,59,249,21,241,41,228,20,126,218,165,19,76,42,157,208,216,39,151,98,130,181,11,145,202,116,14,128,72,216,11,4,112,163,174,214,81,234,41,222,170,12,102,104,184,236,112,213,68,72,74,170,233,215,12,197,6,153,45,106,17,203,133,42,43,36,131,3,241,182,158,228,58,245,235,5,255,22,167,39,154,51,13,244,240,208,91,122,44,78,95,106,87,133,167,199,143,197,81,150,105,6,201,79,116,25,242,146,248,42,96,231,67,113,35,30,17,178,17,137,178,21,211,222,254,225,10,237,137,181,185,56,47,245,226,188,148,58,7,200,107,117,245,82,27,21,145,187,64,65,84,101,173,194,214,53,95,185,147,3,13,37,156,15,39,106,42,235,188,122,162,77,6,234,123,213,178,80,118,186,215,155,116,246,247,63,245,24,160,7,80,12,166,184,117,203,4,246,54,249,26,21,165,190,100,23,153,64,117,88,8,228,214,241,69,132,45,70,88,166,146,166,242,88,43,216,74,101,1,164,136,207,34,37,32,17,162,250,133,146,36,250,153,55,43,84,189,243,249,243,139,167,71,39,167,175,159,127,254,188,115,24,241,175,234,119,192,185,6,41,54,98,156,190,3,185,55,38,95,110,119,186,39,210,5,207,110,92,109,16,107,119,167,8,162,188,70,194,125,83,102,136,207,118,251,26,130,75,93,86,53,108,121,218,214,219,6,203,169,185,212,78,79,114,213,65,215,117,122,138,221,15,159,240,98,77,129,55,91,85,246,74,85,115,155,173,5,99,140,136,149,92,27,178,236,29,82,169,224,122,56,26,33,123,236,53,75,107,107,163,206,30,4,107,15,86,14,79,130,244,154,30,249,218,178,2,121,26,252,63,82,9,59,110,238,46,180,247,236,198,22,222,207,225,180,85,204,7,79,77,230,126,214,213,124,47,232,226,82,230,181,26,139,51,126,122,82,235,156,108,58,241,255,55,194,5,86,195,235,228,220,122,240,189,248,226,165,50,179,106,46,238,123,108,225,113,188,242,180,31,212,148,60,253,13,78,225,246,86,232,30,67,120,89,106,103,77,2,167,210,208,192,154,228,173,36,27,6,108,116,118,139,33,27,65,46,101,35,92,48,212,138,224,141,137,80,224,20,170,138,136,90,114,173,155,162,125,218,8,130,214,11,200,69,254,208,235,221,104,29,77,37,53,252,160,131,108,191,221,57,138,202,60,42,10,216,153,18,245,10,100,224,44,122,207,104,53,44,3,36,237,34,23,108,195,251,67,7,199,167,136,99,64,60,46,14,16,175,139,236,78,12,210,239,13,6,59,209,146,244,213,184,228,188,92,62,87,213,79,228,8,93,73,199,145,222,200,214,235,217,71,54,120,206,186,60,118,152,92,23,173,119,7,9,57,128,170,197,212,39,111,239,166,70,242,70,244,155,149,64,239,42,162,175,28,255,240,67,27,149,79,225,58,165,53,212,82,38,97,125,220,132,99,203,220,122,224,61,18,61,27,195,106,111,214,217,8,229,45,169,230,166,183,61,216,104,5,48,188,116,187,214,222,170,27,106,123,63,168,216,40,216,91,202,112,95,190,91,41,193,207,115,59,33,115,85,212,68,186,78,37,190,119,47,172,81,35,196,139,59,135,195,104,222,213,185,114,207,108,201,233,70,50,146,85,92,12,192,157,113,7,228,224,91,213,120,123,137,17,84,103,234,119,214,248,208,78,222,173,159,108,188,173,9,137,213,106,220,4,106,40,214,77,224,236,124,44,63,154,123,226,239,182,22,178,84,220,218,67,146,169,114,142,67,71,200,25,188,148,103,182,172,25,223,165,30,139,76,57,61,51,52,51,89,65,74,33,35,92,33,42,16,173,132,195,216,251,169,133,10,138,92,86,208,243,34,238,29,139,194,94,169,18,251,38,75,33,41,178,47,165,73,241,248,242,229,43,26,47,84,158,236,140,55,66,116,220,50,220,235,34,195,210,145,92,153,53,187,24,199,16,201,160,103,150,158,12,234,77,9,127,65,6,18,105,141,255,23,170,116,187,34,147,149,76,26,101,60,63,121,251,14,59,50,241,226,244,237,209,17,124,108,81,228,26,206,204,16,37,244,164,105,102,194,160,231,46,132,118,164,9,68,11,172,34,106,7,108,172,14,82,134,46,129,87,231,203,160,39,206,45,226,28,192,24,133,212,37,233,92,187,177,88,6,162,234,183,90,35,137,101,205,118,248,105,158,219,43,114,236,84,22,114,130,124,196,30,216,234,105,180,243,35,5,90,165,174,185,137,123,167,92,1,26,224,159,14,76,152,224,129,120,239,26,227,94,194,55,185,247,165,13,196,245,204,195,161,201,46,176,12,177,232,119,25,176,56,214,64,42,243,28,53,56,133,95,144,200,211,218,132,194,176,202,197,217,133,6,220,211,107,149,214,129,108,5,118,191,120,210,205,38,198,232,8,212,33,158,13,243,0,241,19,113,228,223,146,50,165,87,183,186,30,3,228,183,26,80,154,188,209,71,177,245,78,214,56,151,212,228,158,178,2,137,124,10,4,164,43,2,32,59,236,58,49,179,50,79,196,105,197,40,209,186,240,153,72,28,80,193,138,164,172,66,103,24,45,135,224,104,2,91,176,32,152,64,131,96,224,171,209,31,101,15,182,153,99,82,21,53,108,87,115,141,114,134,236,17,140,239,234,233,84,95,139,143,59,159,89,174,143,59,98,79,39,42,9,61,209,79,50,101,227,248,197,125,246,9,36,203,178,242,103,41,76,145,40,184,185,173,243,12,117,240,210,94,120,77,166,182,244,230,201,88,82,144,94,209,29,35,33,15,154,43,51,0,47,194,105,9,100,231,238,206,239,161,85,102,252,227,142,23,56,96,58,16,84,236,15,68,146,36,31,119,18,241,30,198,128,55,216,64,113,14,21,76,20,72,69,186,164,83,172,90,144,46,227,129,195,130,60,103,70,213,28,41,171,246,102,108,54,206,244,165,50,48,116,61,155,41,199,238,224,35,136,156,142,184,117,172,135,185,68,176,236,193,128,182,68,4,124,81,97,105,130,212,153,145,75,148,42,87,156,77,246,169,12,87,33,238,165,113,72,56,28,248,225,148,42,120,5,156,202,177,177,199,120,11,223,161,224,163,67,14,4,134,241,137,156,85,129,68,151,150,58,246,168,140,193,5,210,176,24,165,58,106,52,227,1,88,52,1,74,193,220,232,148,79,240,200,69,217,208,144,144,37,99,14,238,79,75,13,79,65,90,232,80,32,60,1,7,244,132,12,14,183,53,154,93,159,6,3,152,96,80,235,91,242,230,112,77,28,78,158,63,194,35,11,12,35,72,40,40,51,62,50,14,226,89,80,208,107,163,197,86,137,181,129,37,100,229,107,195,149,45,47,200,178,136,11,48,140,4,232,184,172,20,165,154,162,12,192,88,78,236,169,100,150,160,48,232,47,95,224,141,0,146,16,9,225,112,116,105,117,38,86,28,151,200,209,97,174,39,150,114,92,204,37,50,0,130,209,78,167,208,103,99,225,68,80,229,21,153,118,200,239,46,214,159,251,145,181,152,59,96,196,119,106,202,181,97,138,140,16,225,99,6,73,173,227,204,224,207,150,99,1,12,172,85,164,29,39,58,210,34,147,210,184,162,104,110,210,213,114,76,107,154,91,7,48,88,88,202,220,233,122,206,60,109,29,4,172,176,62,161,229,159,41,118,233,252,139,123,126,127,82,155,174,58,19,149,157,120,150,139,70,221,150,136,186,122,49,1,253,240,178,235,153,148,64,137,33,50,93,103,195,233,73,178,94,71,22,139,154,60,151,249,57,67,239,150,201,146,198,213,87,80,17,205,68,94,12,84,12,231,243,120,183,91,208,110,65,89,152,195,86,211,28,37,158,168,150,121,174,35,214,164,72,192,212,212,47,169,134,54,85,102,12,14,93,205,237,27,154,78,4,248,146,225,155,152,94,99,243,156,163,176,228,62,78,230,87,114,233,168,120,229,116,54,89,218,122,54,167,113,196,219,207,160,27,115,190,8,118,81,8,252,99,52,49,65,229,210,204,106,206,80,78,124,253,250,158,60,232,184,206,145,36,21,229,190,155,27,200,66,161,202,167,100,227,232,149,36,71,31,48,214,103,80,91,78,74,10,6,160,214,162,33,146,108,178,114,218,38,39,236,246,110,128,236,28,21,196,99,80,171,203,136,104,28,11,82,48,106,11,204,17,242,175,211,67,155,100,92,30,60,172,35,165,71,207,96,228,234,45,212,109,52,26,159,161,102,67,155,154,172,58,164,49,242,100,107,102,150,60,160,237,61,106,195,58,84,215,232,188,82,93,81,19,229,187,235,76,153,53,151,56,242,9,201,82,212,179,178,86,179,44,55,10,172,20,24,24,141,192,130,1,107,138,87,199,94,62,201,21,51,49,175,23,146,58,180,19,46,31,148,174,127,117,164,140,235,69,62,238,228,117,164,209,69,195,95,163,73,10,115,223,88,116,88,110,212,11,176,197,166,35,135,98,119,97,236,21,133,231,156,71,225,9,121,240,49,183,64,172,229,163,183,167,92,62,124,81,163,209,145,222,234,106,51,146,250,10,65,24,43,15,111,153,85,238,118,114,216,30,247,121,148,189,83,198,109,61,250,112,29,242,51,237,208,12,118,183,161,246,168,208,119,156,105,251,33,255,43,35,237,217,127,108,164,189,11,198,56,45,180,195,194,16,226,102,174,152,53,160,183,18,8,224,220,67,116,91,136,53,252,17,235,102,175,33,246,82,105,168,96,161,21,247,237,134,159,27,169,25,228,192,229,174,46,165,238,192,31,29,38,219,71,248,206,241,235,255,231,247,225,249,29,233,38,52,214,67,147,252,246,65,94,124,243,73,254,182,161,60,180,54,212,201,113,2,109,7,125,122,79,147,62,247,22,113,214,15,163,254,183,111,154,67,123,140,244,207,223,69,201,65,169,159,153,134,150,138,11,139,207,216,147,48,235,196,10,30,58,106,63,117,80,183,32,47,165,206,169,46,37,60,190,55,29,74,172,54,191,240,16,131,172,133,138,166,205,70,45,234,84,160,248,169,223,181,45,66,79,217,190,77,5,131,105,98,88,19,175,160,107,10,221,140,143,145,199,77,243,50,142,93,29,222,197,126,144,12,170,48,44,167,168,214,196,112,207,32,255,139,139,133,52,17,140,122,241,111,117,164,188,85,166,105,77,46,79,29,128,163,30,153,40,35,90,162,111,83,113,215,198,230,118,182,12,59,38,60,34,163,77,200,173,241,236,250,240,112,54,39,44,225,68,2,88,75,138,55,54,203,70,159,95,212,21,31,196,208,244,217,244,4,72,113,126,178,229,245,183,116,223,65,85,228,160,225,152,189,227,15,16,245,47,103,111,94,11,63,3,36,226,175,138,218,222,16,245,134,63,203,161,217,212,132,71,20,13,162,240,109,199,113,118,166,211,41,158,115,248,40,159,229,56,105,199,207,128,146,88,130,188,160,145,206,125,134,248,112,143,177,98,245,222,39,202,4,169,154,91,58,147,94,159,101,222,212,213,237,66,122,128,33,41,101,89,202,229,154,152,24,12,232,27,1,60,134,154,30,62,26,50,241,138,0,111,226,239,16,226,124,89,108,138,179,202,92,116,225,3,241,140,49,183,177,128,201,148,41,250,41,175,209,164,101,102,59,170,36,192,11,104,104,220,30,153,5,221,210,220,222,94,167,97,94,92,115,214,161,214,59,232,241,202,204,207,199,37,44,68,205,173,251,37,210,5,130,3,206,196,253,113,66,236,138,19,16,59,135,7,51,114,23,142,111,194,217,13,181,128,248,183,123,127,247,213,43,252,201,144,27,95,236,30,236,46,22,248,227,220,238,63,118,27,143,65,211,111,236,160,17,60,3,27,82,31,136,15,95,137,191,131,93,62,51,52,213,238,152,152,0,110,46,94,187,227,142,48,160,74,17,217,104,54,238,184,249,180,45,207,108,233,22,134,211,204,243,161,153,27,179,209,92,231,214,217,98,190,28,55,211,247,24,205,115,134,104,167,143,53,83,109,80,180,16,248,104,236,229,53,237,156,213,126,170,225,227,225,28,67,92,78,149,77,167,52,160,30,91,114,229,205,195,128,115,127,12,64,169,76,149,92,124,38,4,193,233,168,70,181,241,99,82,115,224,192,229,161,115,102,208,224,249,219,230,217,6,56,119,52,109,80,134,41,185,235,231,223,107,71,30,60,63,208,177,220,55,57,119,249,31,29,31,214,0,182,213,171,109,254,246,187,166,145,103,90,229,27,159,248,99,147,12,115,103,60,123,118,239,27,109,222,31,27,175,78,34,143,197,231,162,251,124,140,164,168,250,111,28,109,199,213,220,62,26,18,160,255,146,66,148,96,117,100,122,174,250,62,14,14,223,136,139,95,70,249,243,123,143,80,43,223,154,227,37,58,154,134,87,201,78,227,101,164,232,75,14,213,128,62,38,175,82,25,141,82,212,233,158,75,156,9,125,213,60,104,62,69,7,172,225,70,72,255,7,207,189,246,235,49,223,102,59,220,66,1,51,230,0,129,254,233,115,8,127,56,117,106,112,209,25,215,149,199,179,126,165,113,239,143,59,239,59,23,26,87,47,126,122,205,28,136,175,254,199,13,66,157,11,143,157,70,165,173,93,123,233,177,206,7,15,249,9,130,4,145,154,143,209,163,230,139,117,119,101,75,168,244,222,1,226,219,126,218,204,145,15,171,204,166,226,1,223,190,236,187,24,244,13,47,97,6,135,233,245,50,192,12,184,121,80,220,97,143,248,201,202,221,165,149,107,66,253,74,233,187,193,135,119,255,4,233,64,153,5,64,45,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a20b2ceb-a143-40d1-89d2-167034a45c75"));
		}

		#endregion

	}

	#endregion

}

