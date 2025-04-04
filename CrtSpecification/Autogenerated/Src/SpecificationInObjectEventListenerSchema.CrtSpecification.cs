﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SpecificationInObjectEventListenerSchema

	/// <exclude/>
	public class SpecificationInObjectEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SpecificationInObjectEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SpecificationInObjectEventListenerSchema(SpecificationInObjectEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d94d2247-ebac-4c9b-a7dc-e759e66ab87b");
			Name = "SpecificationInObjectEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("356cd724-5c53-4074-944f-dbf1a0fcb7ef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,87,223,111,219,54,16,126,78,129,254,15,172,182,7,7,136,20,255,140,237,180,9,208,166,73,17,32,109,183,37,91,49,12,123,160,200,147,163,85,38,61,146,114,225,6,249,223,119,34,37,89,146,229,184,233,58,108,123,137,35,234,238,187,239,190,59,82,71,34,232,28,244,130,50,32,55,160,20,213,50,50,193,153,20,81,60,75,21,53,177,20,79,159,220,61,125,178,151,234,88,204,200,245,74,27,152,63,47,159,207,20,100,54,193,5,254,164,10,110,228,108,150,224,250,218,160,138,57,159,75,209,254,70,193,182,245,224,92,152,216,196,160,119,26,4,231,75,16,38,179,67,203,239,20,204,144,58,57,75,168,214,199,228,122,1,44,142,98,102,243,185,20,239,195,63,128,25,107,127,21,99,66,2,148,245,250,205,98,173,106,47,58,215,236,22,230,244,29,170,68,78,136,215,64,186,2,202,189,253,223,191,202,247,7,37,121,202,140,115,95,164,97,18,51,194,50,190,95,64,151,28,147,87,84,67,75,76,196,186,179,201,236,49,41,180,33,218,40,91,56,251,115,179,90,88,38,99,74,249,176,55,165,254,20,198,212,31,142,39,35,127,194,123,3,159,141,163,168,55,236,246,161,55,224,222,243,13,144,75,97,96,6,170,64,233,247,123,253,254,176,71,253,113,15,66,127,120,52,9,125,58,224,35,159,117,163,193,148,71,48,234,177,105,11,202,107,76,110,78,147,2,37,132,112,120,52,26,244,252,97,212,159,250,195,81,159,249,33,244,38,126,15,248,40,234,81,58,9,39,221,54,20,37,23,175,229,39,145,229,93,64,1,139,70,227,9,237,250,195,112,200,253,97,23,142,252,105,119,202,252,193,148,70,125,58,158,78,248,160,223,2,245,74,202,4,168,40,80,6,163,41,116,97,48,242,195,112,128,132,162,238,216,159,134,211,200,167,192,142,40,239,142,143,38,253,137,231,218,172,236,179,139,24,18,142,141,134,53,53,88,43,224,238,245,225,225,33,121,161,211,249,156,170,213,233,122,1,128,48,5,209,137,247,179,6,133,123,77,160,11,162,120,135,167,36,70,94,84,48,8,74,235,195,170,255,162,192,39,117,215,230,227,29,153,129,121,78,22,42,94,82,3,68,103,15,247,57,101,16,220,177,174,167,240,22,204,173,116,57,88,39,247,182,64,184,146,140,38,241,103,26,38,224,90,137,188,1,179,177,216,201,21,77,216,231,172,233,247,73,118,114,236,237,41,192,195,65,16,1,159,54,113,58,117,230,193,7,169,62,218,227,40,248,9,180,76,21,67,59,169,232,12,14,44,212,94,115,23,181,108,14,239,128,124,239,109,4,210,193,93,78,235,62,248,133,38,41,120,251,182,21,238,235,137,46,101,140,226,46,56,254,239,252,172,173,19,167,227,246,27,1,251,83,100,135,69,66,254,75,80,216,80,85,110,100,153,121,18,35,73,5,200,122,196,17,233,228,39,166,14,80,199,75,125,46,50,162,188,227,93,131,169,37,88,113,253,16,155,91,236,47,6,90,123,251,69,240,92,91,155,73,150,10,254,109,180,194,73,78,55,168,175,59,143,37,85,117,210,217,38,184,228,232,228,42,25,156,207,23,102,181,197,214,178,250,50,83,11,153,243,192,132,179,40,252,76,38,233,220,129,188,120,147,198,252,180,211,168,45,207,43,100,245,218,128,59,33,153,147,139,218,174,70,190,71,45,27,208,127,98,63,165,137,65,30,89,31,186,74,186,243,249,199,20,212,170,217,135,85,131,183,84,96,3,170,131,198,17,94,208,43,177,131,151,60,207,170,227,101,41,22,6,133,28,121,251,156,172,217,100,98,184,213,70,252,131,166,126,57,212,150,98,149,224,173,234,186,2,157,58,82,185,172,69,235,162,182,66,150,71,225,178,214,163,109,193,158,157,84,190,37,165,238,121,105,177,123,43,113,177,158,235,238,197,77,89,237,147,253,70,141,244,167,216,176,219,182,136,101,12,36,155,179,52,248,194,173,49,252,8,146,78,133,208,177,91,223,70,8,191,96,5,155,110,78,97,171,237,69,34,233,218,58,216,105,159,127,70,10,143,136,38,26,118,249,100,71,214,37,78,84,246,17,43,115,64,68,154,36,165,87,181,157,109,177,132,217,72,190,242,81,46,179,111,221,166,15,108,191,178,65,74,125,254,7,226,132,56,123,126,92,107,19,101,140,54,212,169,12,27,127,95,157,74,210,187,184,63,166,209,254,121,109,66,23,97,67,157,202,228,83,170,147,109,252,7,196,200,160,78,27,156,215,95,35,119,214,173,64,95,177,207,40,106,235,140,224,253,10,122,173,95,123,53,28,66,112,35,115,159,210,252,158,0,170,83,15,39,228,67,209,222,201,93,193,172,127,91,172,111,187,5,30,211,18,143,43,111,130,214,36,70,243,202,249,93,244,127,99,76,254,207,30,144,89,33,147,122,214,88,154,47,152,25,154,82,149,136,89,35,55,17,159,85,167,6,210,104,219,194,248,155,15,10,5,197,74,35,214,99,85,7,135,108,66,173,24,86,137,33,165,134,223,246,241,161,145,249,142,45,80,88,63,124,254,213,169,221,147,150,110,228,16,81,36,118,76,154,147,216,246,182,104,12,9,27,244,106,99,250,238,219,139,189,72,87,174,95,177,184,5,21,27,46,89,126,233,218,114,113,14,222,227,109,2,69,52,72,6,111,98,246,78,224,46,229,18,103,123,21,243,252,110,80,49,235,72,123,249,192,235,149,224,89,213,29,234,43,136,164,2,139,253,82,205,52,41,167,164,16,3,87,163,116,10,191,98,23,108,187,118,56,59,66,117,30,161,166,200,99,147,188,166,203,157,25,58,155,175,75,47,247,253,87,114,179,65,118,102,87,88,125,93,126,165,247,55,201,176,209,207,110,181,190,136,107,127,1,114,219,234,180,165,19,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNoLocalizableString());
			LocalizableStrings.Add(CreateYesLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNoLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2fd7c3db-a592-9d77-393b-c45d79f54f69"),
				Name = "No",
				CreatedInPackageId = new Guid("356cd724-5c53-4074-944f-dbf1a0fcb7ef"),
				CreatedInSchemaUId = new Guid("d94d2247-ebac-4c9b-a7dc-e759e66ab87b"),
				ModifiedInSchemaUId = new Guid("d94d2247-ebac-4c9b-a7dc-e759e66ab87b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateYesLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("35526315-084d-7526-c4b8-4bebc59567ad"),
				Name = "Yes",
				CreatedInPackageId = new Guid("356cd724-5c53-4074-944f-dbf1a0fcb7ef"),
				CreatedInSchemaUId = new Guid("d94d2247-ebac-4c9b-a7dc-e759e66ab87b"),
				ModifiedInSchemaUId = new Guid("d94d2247-ebac-4c9b-a7dc-e759e66ab87b")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d94d2247-ebac-4c9b-a7dc-e759e66ab87b"));
		}

		#endregion

	}

	#endregion

}

