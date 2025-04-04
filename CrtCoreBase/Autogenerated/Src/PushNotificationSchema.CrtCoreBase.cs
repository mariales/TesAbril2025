﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PushNotificationSchema

	/// <exclude/>
	public class PushNotificationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PushNotificationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PushNotificationSchema(PushNotificationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a7933308-4a2e-4831-9e68-33433e9c1b4a");
			Name = "PushNotification";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d653ba80-e9e2-4f78-8775-8ba14502d8a8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,87,75,115,219,54,16,62,43,51,249,15,176,114,161,102,52,116,46,189,36,126,140,223,85,39,182,19,203,110,142,25,136,92,75,104,73,80,1,64,41,106,227,255,222,197,139,2,33,50,182,103,122,177,140,197,226,219,7,190,93,44,57,45,65,46,105,6,228,30,132,160,178,122,84,233,89,197,31,217,188,22,84,177,138,191,125,243,239,219,55,131,90,50,62,39,211,141,84,80,126,140,214,168,95,20,144,105,101,153,94,1,7,193,178,173,78,8,43,160,79,158,158,159,246,110,93,112,197,20,3,217,171,112,73,51,85,137,150,198,13,172,21,186,163,85,254,144,21,239,62,90,150,125,59,8,218,74,2,106,161,222,59,1,115,92,144,179,130,74,249,129,124,174,229,226,166,82,236,145,101,46,83,168,179,191,191,79,14,100,93,150,84,108,142,220,90,43,18,30,104,166,94,113,63,208,92,214,179,130,101,36,211,224,29,216,3,125,13,91,23,48,56,37,106,29,183,241,68,31,53,246,61,76,12,144,60,72,16,120,138,219,139,34,117,107,57,34,6,125,240,173,45,38,135,145,158,206,214,224,201,26,122,7,60,183,222,184,181,115,237,146,65,145,107,167,4,91,81,5,206,43,187,32,2,104,94,241,98,67,34,119,190,237,216,137,77,12,6,161,145,107,80,139,170,215,202,172,170,10,114,70,249,167,106,158,248,208,86,84,16,208,76,218,76,179,5,148,20,99,139,140,90,162,185,237,107,202,233,28,68,122,201,120,62,193,92,83,158,193,233,230,6,171,37,25,94,87,51,86,64,152,93,52,52,28,125,236,180,243,48,201,209,84,40,57,78,81,102,149,217,35,73,246,34,237,244,119,42,255,164,69,13,228,231,207,24,41,53,27,233,68,94,148,75,181,73,70,62,184,129,0,85,11,78,30,105,33,193,66,63,153,191,78,142,84,129,240,238,124,162,144,67,134,250,162,230,24,8,36,110,189,210,86,198,132,113,69,74,250,227,19,240,185,90,120,83,218,101,171,134,110,220,212,69,113,43,172,51,230,208,142,71,70,218,225,145,145,167,22,154,28,28,110,237,144,99,187,71,62,56,157,105,61,179,246,146,247,227,192,157,151,80,49,96,73,165,240,146,33,247,225,187,37,89,49,161,106,90,144,73,92,47,120,98,197,114,16,228,12,41,171,192,47,61,21,124,166,76,181,106,86,140,125,46,37,40,133,191,50,228,221,186,18,127,155,38,123,191,89,54,80,200,10,211,72,108,247,218,96,231,84,7,147,175,93,154,71,137,227,150,22,90,147,230,191,195,110,96,141,164,215,73,227,156,59,222,31,228,50,10,15,161,57,94,237,150,164,91,163,123,118,171,185,103,23,54,110,67,57,43,54,95,48,155,136,15,185,182,139,48,205,193,244,164,75,195,90,24,116,216,111,229,230,178,18,25,152,4,245,133,112,148,116,122,48,182,248,3,14,235,176,103,158,136,121,93,98,109,37,67,127,93,195,241,246,230,70,29,124,141,61,108,87,83,76,167,85,197,114,130,77,225,156,42,154,196,46,107,33,201,241,79,72,17,94,173,63,83,129,30,43,195,12,237,239,151,26,196,166,17,38,67,84,65,47,241,52,220,179,18,210,7,149,221,84,235,49,25,122,73,216,129,178,90,8,140,207,117,89,133,105,156,228,207,225,7,103,38,249,208,101,46,238,145,103,91,165,180,65,30,109,137,162,227,74,113,46,56,201,75,198,31,56,195,221,29,202,104,7,231,53,211,125,241,10,127,82,124,172,245,175,103,249,64,47,136,108,99,28,146,46,228,227,99,139,96,58,144,59,173,67,195,91,2,161,146,200,249,81,58,225,170,234,237,223,142,42,233,20,144,23,58,3,200,152,162,46,121,186,205,145,246,122,212,86,180,253,33,191,229,168,31,94,98,167,214,233,198,224,254,242,118,218,7,175,171,220,144,249,25,124,175,246,122,3,247,76,21,208,21,107,243,40,152,196,27,181,49,249,237,253,40,138,255,26,164,196,151,242,121,4,167,168,49,118,64,218,215,218,133,213,166,67,116,252,36,207,153,190,70,90,232,218,234,58,174,135,64,204,196,10,89,129,71,4,195,22,241,15,220,206,254,66,98,88,239,218,16,129,127,23,63,32,171,49,6,79,206,184,32,206,79,167,168,32,240,149,190,224,115,198,65,123,20,14,18,119,144,85,34,191,99,243,133,250,4,43,40,162,72,124,131,234,33,229,216,20,202,152,244,32,222,46,193,14,168,233,29,14,86,30,235,87,230,211,147,162,168,214,39,60,191,18,148,171,177,153,12,194,126,247,226,23,213,141,156,118,44,115,67,103,171,253,77,17,34,233,40,229,230,165,84,150,82,110,85,90,122,248,38,97,78,199,7,221,137,210,51,201,116,149,86,39,254,223,252,192,70,203,204,5,227,116,126,96,183,188,202,17,161,109,178,4,147,209,94,76,15,124,180,38,242,18,139,191,22,112,193,233,172,128,60,25,98,93,218,235,142,159,6,57,140,7,168,240,41,10,239,149,200,215,76,177,218,139,104,136,141,77,99,85,172,88,214,122,68,64,126,119,79,69,136,105,158,141,196,154,119,202,59,219,182,254,154,23,213,45,15,53,162,174,52,187,198,178,247,143,239,51,56,205,32,211,7,116,230,21,60,146,222,191,100,5,150,190,212,122,137,94,219,30,108,165,95,153,90,52,221,65,38,86,136,95,132,75,42,24,182,10,51,176,92,124,71,14,225,251,234,174,109,232,138,165,229,235,246,211,215,141,234,129,192,122,121,229,219,193,118,103,231,93,218,166,92,247,34,151,243,174,177,161,249,154,25,76,227,231,177,179,173,152,174,141,155,150,226,86,230,250,48,74,61,213,173,188,221,1,113,187,205,114,203,67,235,233,35,126,32,211,108,65,18,237,50,83,80,226,167,194,78,252,173,231,222,51,1,97,181,190,31,81,221,5,154,175,26,87,101,71,73,155,53,105,48,192,218,209,198,223,245,75,176,34,230,180,192,94,53,14,247,124,6,132,243,191,31,31,123,102,218,212,52,34,51,247,133,69,173,187,134,255,84,109,82,230,71,199,88,187,187,59,91,105,91,248,244,31,237,199,93,187,217,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a7933308-4a2e-4831-9e68-33433e9c1b4a"));
		}

		#endregion

	}

	#endregion

}

