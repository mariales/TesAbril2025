﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailParticipantHelperSchema

	/// <exclude/>
	public class EmailParticipantHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailParticipantHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailParticipantHelperSchema(EmailParticipantHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1b6d391b-284d-43bd-8069-c889c1488d04");
			Name = "EmailParticipantHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("90e754d6-7d4f-478a-b96c-485ce65b1271");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,28,107,111,220,184,241,243,30,208,255,192,108,129,131,22,216,202,77,191,20,72,178,27,56,126,164,139,38,23,195,78,122,31,130,124,144,87,180,173,70,43,237,137,90,59,190,36,255,189,51,28,146,34,41,234,177,142,83,224,112,182,37,114,56,195,121,63,148,34,217,112,177,77,214,156,189,231,85,149,136,242,170,142,143,202,226,42,187,222,85,73,157,149,197,95,126,249,250,151,95,38,59,145,21,215,236,226,94,212,124,243,220,251,27,214,231,57,95,227,98,17,191,230,5,175,178,117,107,205,113,82,39,173,135,111,178,226,143,230,161,141,192,102,83,22,225,55,21,239,122,30,31,191,234,124,117,82,212,89,157,113,209,185,224,162,38,200,240,254,175,21,191,6,90,216,81,158,8,241,140,157,108,146,44,63,75,170,58,91,103,219,164,168,255,197,243,45,175,228,202,131,131,3,246,66,236,54,155,164,186,95,170,191,225,242,234,36,43,4,219,213,89,158,213,247,108,195,235,155,50,21,236,170,172,216,93,89,125,102,119,89,125,195,56,66,101,219,6,172,136,53,192,3,11,226,118,119,153,103,107,182,70,84,58,48,97,176,236,171,68,167,193,28,56,81,87,187,53,208,4,4,156,73,24,180,194,199,152,80,174,120,82,243,78,248,64,76,157,20,107,30,27,0,7,62,132,23,64,72,178,97,5,8,211,98,186,19,188,2,12,10,18,137,233,242,3,252,205,214,230,65,252,226,64,174,150,155,21,125,225,147,163,15,14,36,230,2,158,49,20,204,201,196,91,180,240,150,33,199,39,223,213,253,240,34,165,43,114,239,235,172,42,225,56,148,143,103,248,123,13,59,121,218,115,97,39,95,50,81,163,16,17,23,65,131,68,114,205,29,110,18,151,171,50,135,123,77,51,137,9,64,232,184,194,173,62,147,29,155,165,47,94,239,178,116,206,222,192,73,242,215,229,146,157,217,240,191,178,107,94,63,103,2,255,247,189,15,87,68,81,176,28,224,176,75,14,66,200,21,214,235,155,164,184,230,233,32,74,18,3,16,39,160,119,201,222,229,169,2,232,156,15,183,94,240,59,103,105,52,123,62,18,171,228,170,6,1,249,1,164,126,227,119,251,34,53,74,18,134,244,230,133,224,156,173,43,126,181,152,30,2,219,110,65,219,45,22,157,3,239,167,7,75,150,151,229,231,221,182,139,34,146,127,139,237,132,233,156,73,158,51,15,222,158,108,55,146,41,128,92,125,199,253,152,208,241,236,66,110,32,32,234,200,177,103,86,124,205,183,25,71,25,77,82,184,100,33,56,49,186,255,96,135,163,231,6,198,227,73,27,152,160,237,253,163,96,119,4,128,126,10,134,112,84,145,62,30,158,175,16,220,79,64,22,87,218,8,242,191,73,236,27,60,209,213,165,60,231,117,151,207,24,195,243,211,178,58,150,48,30,3,91,220,210,131,241,30,104,130,177,249,25,215,89,230,233,35,33,8,38,250,145,17,4,146,209,127,215,201,186,102,187,34,251,99,199,179,20,128,103,87,153,140,14,148,233,198,39,117,167,135,35,68,209,168,33,184,35,130,182,74,71,219,51,160,234,49,113,0,112,251,227,16,176,247,104,224,7,226,35,29,226,72,212,152,99,82,247,57,209,13,115,198,159,235,133,71,222,159,99,17,65,17,72,20,205,110,156,35,99,57,208,210,106,64,70,91,145,77,192,231,149,151,255,5,188,32,210,89,21,128,38,248,249,255,36,249,206,119,122,74,124,247,129,215,47,222,167,121,2,107,193,84,102,107,25,6,103,87,142,52,177,76,224,129,253,212,93,150,101,206,86,2,175,41,112,165,93,209,198,91,74,13,156,160,115,50,25,140,211,195,140,184,170,202,13,202,132,188,56,118,43,111,110,48,142,186,205,170,122,151,228,236,182,4,165,32,248,129,80,70,156,2,108,151,39,145,14,191,111,147,202,32,100,109,185,88,223,192,37,2,175,92,129,163,68,236,158,222,190,77,10,8,78,42,200,25,235,149,146,229,87,247,191,129,52,69,161,120,106,58,147,161,252,4,67,216,100,125,195,34,60,217,186,129,51,20,68,129,182,192,197,84,35,218,133,41,224,216,137,127,76,87,66,72,123,233,136,66,103,18,216,28,195,202,195,116,147,21,231,217,245,13,176,102,193,94,231,229,101,146,31,110,183,23,188,198,204,65,196,167,0,120,87,113,119,229,170,56,217,92,242,52,229,233,155,242,154,178,232,142,19,0,206,49,191,130,204,123,183,41,52,71,250,151,91,107,155,251,93,165,211,57,217,164,248,172,202,80,64,172,101,251,0,180,222,73,152,45,198,196,255,230,247,26,160,207,66,50,32,200,186,246,54,194,68,243,112,162,226,211,207,252,30,110,213,108,69,224,10,246,132,148,158,20,192,89,35,33,233,85,35,104,130,51,230,4,70,227,61,1,211,16,209,109,129,204,190,191,223,242,212,218,64,105,90,52,165,216,217,184,151,233,140,45,22,210,235,196,39,155,45,104,237,175,191,186,136,227,235,41,70,247,114,173,38,116,34,253,212,214,141,255,193,89,145,245,195,151,145,196,45,126,95,94,200,59,137,102,6,77,137,103,96,235,162,149,79,124,156,162,106,79,63,89,231,78,224,26,36,141,14,29,81,47,67,101,134,109,255,252,222,35,57,201,45,215,178,250,221,74,206,131,38,15,112,17,202,26,171,28,70,5,1,141,101,179,75,15,194,187,250,229,73,96,43,107,34,7,167,22,49,218,78,134,47,72,242,203,67,192,212,40,182,41,152,17,182,163,31,196,66,122,230,25,149,57,107,66,139,25,221,33,138,101,91,168,230,140,36,47,62,211,162,20,249,103,235,253,191,223,240,10,52,20,165,43,94,137,147,63,128,142,168,181,185,211,6,204,88,34,20,174,196,51,34,34,62,249,194,215,187,90,115,178,143,135,135,105,26,246,89,172,46,71,58,172,22,163,183,142,185,89,218,230,220,143,14,219,60,238,0,68,98,237,2,179,162,155,94,48,229,45,175,42,56,83,87,134,108,191,181,164,0,163,174,192,30,129,98,102,152,141,0,193,64,188,146,135,208,221,184,85,178,176,28,194,197,6,252,228,251,210,243,212,190,33,89,165,115,146,140,238,136,169,109,135,231,20,226,244,208,169,101,29,109,207,147,149,240,75,122,114,135,120,117,47,205,78,228,162,211,50,75,51,52,146,81,207,97,236,219,55,162,225,137,75,108,172,203,175,96,156,220,67,102,51,99,227,220,45,31,157,101,159,200,101,184,196,143,52,86,175,209,88,141,40,181,116,152,173,233,178,37,98,21,135,24,161,16,203,11,27,232,139,3,253,56,44,27,202,69,2,54,86,21,39,82,79,233,40,125,21,78,226,72,175,100,54,186,80,127,160,129,16,92,2,56,164,84,84,91,110,228,114,179,1,174,125,7,76,89,178,167,230,146,25,33,105,65,141,223,36,162,118,44,255,164,189,134,0,129,167,122,202,94,90,207,63,254,253,19,123,166,40,35,55,58,104,118,94,27,215,33,216,229,189,186,112,72,165,212,157,67,12,178,1,229,83,229,76,200,167,198,50,203,219,184,60,149,127,35,3,232,176,182,161,208,236,34,103,36,139,56,67,60,116,24,243,90,249,27,208,158,83,231,112,205,84,23,37,205,2,117,185,238,203,78,142,246,93,37,213,97,4,75,119,219,92,38,73,154,86,12,217,144,30,193,202,43,59,89,245,11,16,152,174,38,69,106,47,9,213,165,112,153,62,211,91,222,89,203,130,61,123,57,111,162,229,88,83,162,160,152,116,198,7,31,159,243,13,216,161,200,82,37,37,193,33,100,212,234,195,60,143,178,154,111,216,2,178,116,249,115,225,84,84,191,125,107,85,187,140,225,146,27,117,40,215,73,245,163,29,132,75,130,7,132,240,233,147,145,206,44,218,118,248,92,58,1,84,199,250,134,183,84,82,118,75,246,208,196,117,19,231,29,141,8,237,236,173,116,212,82,246,31,64,116,109,28,229,171,110,37,118,157,249,16,137,26,88,191,182,171,234,65,191,203,148,110,220,144,28,172,119,80,207,160,34,15,218,120,99,179,9,194,191,223,202,90,154,207,168,113,135,210,97,219,217,190,227,68,215,77,60,105,114,4,109,89,146,92,232,132,74,5,252,171,147,98,183,225,85,114,153,171,116,200,207,96,48,25,182,207,250,104,224,127,82,144,20,112,127,95,124,88,220,71,72,26,202,122,101,158,124,190,221,226,3,248,65,249,93,44,227,91,33,87,206,102,33,103,227,80,138,32,36,0,189,253,65,167,56,218,241,241,221,165,40,209,198,68,211,223,179,28,152,11,82,32,149,53,85,157,174,127,198,79,159,198,255,152,206,62,245,135,118,100,168,188,114,203,35,157,33,5,206,59,67,59,147,166,10,61,119,221,80,229,153,136,57,243,119,248,158,199,200,199,160,159,78,128,8,229,82,100,29,203,105,172,246,217,3,173,88,50,108,233,133,178,175,203,133,196,44,245,156,131,162,203,244,27,85,106,85,161,84,47,217,19,211,28,109,140,39,188,154,205,32,69,71,224,35,28,237,155,50,129,92,137,235,246,178,111,32,37,61,232,36,157,194,159,52,98,146,94,200,38,146,203,68,52,23,134,245,72,117,33,226,115,182,21,96,147,50,129,19,9,101,87,139,181,101,41,233,204,229,80,237,187,35,93,65,89,70,162,124,211,38,34,85,15,151,224,245,253,58,13,238,142,50,175,213,16,183,99,81,89,123,53,22,138,24,101,43,255,5,199,17,21,136,40,241,135,91,253,195,99,232,181,95,225,83,230,46,166,124,216,47,114,181,94,235,26,142,202,187,177,178,210,81,201,116,51,115,171,24,215,147,161,243,222,12,157,8,80,25,186,28,112,137,142,95,81,142,142,205,184,75,243,107,160,34,43,118,21,63,126,213,60,178,124,131,2,181,194,241,157,115,158,96,18,82,209,143,69,251,46,117,77,128,22,70,205,161,150,235,184,187,201,192,184,70,4,36,198,149,214,105,237,162,151,44,120,169,197,175,157,242,156,174,182,121,60,121,238,64,170,116,205,172,23,132,230,155,83,62,235,246,136,94,90,105,85,206,28,199,214,74,43,77,211,141,142,109,215,206,38,205,91,53,57,226,249,74,23,164,217,175,252,84,154,174,174,208,189,203,168,33,34,210,205,33,78,93,110,92,217,205,43,205,200,174,110,120,108,105,175,210,89,79,31,65,153,170,133,111,126,137,136,150,41,208,198,90,133,16,106,163,10,5,33,110,82,219,253,10,27,157,226,119,19,128,179,18,163,179,36,171,194,240,49,217,209,71,25,174,43,23,168,158,83,212,189,48,69,74,187,228,236,198,111,214,162,166,118,237,202,172,13,83,7,28,86,112,63,103,84,247,61,42,55,192,143,76,128,42,175,10,184,197,12,184,114,180,203,177,185,176,186,46,128,188,35,240,8,51,200,166,187,106,191,144,88,183,95,189,47,167,90,192,70,150,153,154,208,84,137,156,103,190,253,18,147,81,155,175,108,138,118,224,109,82,125,158,206,41,104,96,223,231,246,91,210,207,185,190,26,83,107,166,56,124,230,218,121,32,190,170,56,150,110,224,64,194,117,132,231,149,18,191,166,157,114,130,12,235,115,45,105,223,91,216,67,184,40,202,37,179,213,172,154,145,9,207,54,171,237,248,52,54,203,158,27,125,113,42,190,99,197,223,239,253,107,70,88,162,69,247,169,238,85,198,138,9,200,128,48,57,34,156,212,87,119,115,136,194,82,158,226,215,96,85,208,217,24,168,10,250,8,169,178,216,194,187,136,62,100,116,221,112,98,171,18,58,93,74,138,176,238,232,210,106,197,24,214,153,70,255,71,42,135,75,217,15,41,136,76,61,195,250,209,169,225,29,26,195,56,234,154,33,237,220,143,227,255,111,212,117,19,128,118,200,70,95,154,135,177,221,35,106,91,168,193,86,39,75,7,154,49,61,87,29,254,164,6,212,111,168,38,143,143,91,61,166,49,218,78,135,217,254,250,213,189,238,13,217,217,184,167,226,216,252,22,170,25,124,82,96,226,156,70,211,227,18,28,185,234,61,123,26,115,90,234,171,158,206,122,226,93,52,15,153,104,70,109,80,101,237,193,27,237,80,236,65,152,89,99,89,138,82,242,157,7,82,118,202,198,41,116,181,107,79,166,149,105,71,186,70,223,156,21,231,92,108,203,66,100,64,236,20,179,163,70,76,162,47,8,238,11,174,156,51,245,187,221,139,150,145,153,67,135,163,186,14,197,227,237,142,13,48,96,118,246,85,7,117,172,3,117,95,165,232,211,9,251,130,63,53,186,161,126,145,26,66,191,59,158,209,232,122,228,220,210,183,111,44,124,159,198,112,179,193,210,148,45,68,115,87,118,44,40,65,249,27,227,240,26,6,80,213,211,71,198,232,217,42,13,201,179,109,38,30,92,56,65,13,95,21,89,157,37,121,246,39,23,157,195,138,94,161,166,39,214,112,134,217,172,194,37,219,154,25,228,177,57,186,12,208,167,75,117,121,157,115,114,3,45,204,156,228,119,186,236,155,181,27,211,151,188,104,162,16,224,136,61,143,161,37,157,233,195,52,103,157,153,192,133,30,222,128,156,105,7,76,122,105,79,79,60,27,156,127,112,102,251,22,230,168,65,112,122,97,11,226,96,115,123,91,241,219,172,220,9,217,180,208,65,164,221,8,84,4,129,123,177,234,40,166,140,20,232,142,152,82,146,156,32,71,93,219,83,22,2,245,154,152,66,23,132,184,150,73,176,65,149,46,114,164,116,140,130,108,110,164,13,218,83,42,28,7,177,66,177,227,236,234,106,156,200,160,41,163,107,125,66,140,245,115,50,174,146,49,175,17,170,234,156,51,103,178,7,129,113,21,10,6,74,228,147,166,228,231,165,217,220,234,8,217,217,181,132,104,68,239,97,24,26,138,71,34,217,212,31,71,34,217,39,216,218,216,225,60,183,53,152,76,117,85,10,155,252,242,36,137,158,22,102,239,165,17,160,241,253,29,37,202,141,173,221,79,80,223,185,35,213,29,123,117,81,216,58,197,235,208,178,176,169,115,114,168,198,53,52,112,70,91,190,118,239,45,231,73,21,53,230,172,127,65,183,34,56,40,218,197,149,142,118,114,80,53,66,3,239,11,5,173,89,98,94,52,154,242,161,192,90,162,170,182,168,128,81,246,85,158,112,20,96,64,244,93,165,101,216,45,145,143,81,161,135,210,230,43,85,104,92,222,35,175,249,232,105,209,124,0,245,227,228,53,221,132,22,127,91,125,133,238,246,236,158,29,134,115,14,215,192,111,185,104,170,102,178,127,176,38,120,104,149,116,83,52,216,125,216,167,63,235,127,8,120,104,218,5,8,94,38,90,118,193,165,227,19,193,112,71,66,76,151,236,208,160,202,189,175,37,58,181,252,141,218,160,137,31,108,205,118,22,29,135,75,45,222,135,136,94,55,141,135,102,53,20,196,15,242,211,81,12,0,67,167,248,96,185,45,51,131,18,248,248,189,74,10,202,145,118,161,113,29,186,137,193,82,174,74,102,100,169,39,147,85,204,179,178,170,147,92,158,2,106,72,101,128,199,239,137,174,4,158,96,18,10,233,63,135,136,241,26,243,123,96,222,217,40,253,161,52,5,71,195,43,88,38,251,79,143,115,71,234,110,220,60,87,155,32,204,243,34,83,7,79,7,137,235,178,75,168,133,221,45,79,245,101,168,14,48,247,27,23,125,64,19,179,61,50,194,175,241,219,118,112,41,242,147,102,217,108,86,22,71,33,37,176,17,167,241,188,202,147,235,110,59,100,97,66,141,80,171,45,165,194,232,220,216,194,126,11,101,143,92,180,96,145,157,34,148,156,143,5,236,246,171,154,237,108,8,180,67,236,246,83,205,88,72,156,62,126,98,95,153,154,77,158,206,89,51,247,133,127,56,99,69,248,160,61,205,52,53,165,189,88,117,96,11,180,95,152,146,181,72,241,155,179,77,177,4,63,25,193,254,154,169,137,170,124,79,205,75,186,77,191,200,180,117,191,135,188,113,179,37,112,105,142,237,28,254,168,103,232,251,97,45,243,111,202,181,12,29,83,118,151,84,210,5,39,151,229,174,102,27,252,88,187,6,60,88,89,184,223,240,226,215,69,163,166,34,30,6,217,19,57,250,196,169,119,188,244,45,0,124,127,195,139,119,5,247,167,37,100,191,129,240,64,25,85,169,181,87,247,57,231,162,220,85,107,142,255,12,67,114,13,209,242,212,47,242,208,63,9,48,213,60,158,182,64,138,56,140,15,213,15,101,157,81,167,245,131,214,72,133,243,201,159,56,200,70,191,15,127,232,214,101,117,78,172,143,201,198,155,24,8,95,215,220,210,73,239,99,47,223,186,120,76,242,234,85,102,138,96,64,241,125,255,228,215,30,3,149,96,246,242,37,211,198,20,227,22,25,179,216,85,112,42,17,6,191,157,210,237,82,137,12,61,10,15,139,216,9,172,51,200,140,189,31,127,40,216,105,141,73,103,177,80,159,56,233,143,186,200,90,199,167,96,142,244,7,103,202,134,181,166,155,21,132,86,2,175,79,63,209,246,162,245,53,144,254,180,214,134,19,91,11,240,92,175,117,217,12,110,182,106,2,106,110,219,107,90,183,140,164,118,143,89,209,101,248,21,227,45,179,222,16,117,151,213,8,149,96,196,18,65,99,101,215,9,248,60,125,77,207,180,165,117,113,86,27,157,132,13,203,109,225,242,134,189,122,22,154,238,150,7,4,202,67,246,198,185,62,244,157,151,215,65,8,6,151,244,249,185,131,126,227,120,12,5,129,228,47,152,204,63,252,80,215,227,153,131,131,31,230,63,250,225,1,159,107,48,232,254,247,1,126,194,29,232,81,93,75,116,236,42,241,67,64,167,252,42,217,229,245,179,208,75,187,20,215,53,242,61,110,40,192,181,187,101,229,36,174,220,182,237,97,183,16,178,204,250,11,50,199,200,105,93,11,204,200,16,81,189,29,70,53,148,190,215,39,188,63,144,114,4,136,10,55,103,252,209,213,142,72,8,183,138,192,56,117,224,203,141,102,236,251,135,70,197,251,59,27,163,233,179,155,79,110,38,168,249,41,123,126,212,28,10,206,23,62,246,160,224,73,231,160,160,130,118,88,164,205,208,91,55,156,129,198,163,11,206,27,195,235,134,106,205,147,135,191,33,252,113,65,68,159,17,184,77,29,250,4,62,74,117,69,212,139,236,189,63,97,17,252,247,63,53,77,38,217,56,77,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSenderEmailMoreThenOneLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSenderEmailMoreThenOneLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7d978846-21ff-482c-ab99-6b758aeb0cfc"),
				Name = "SenderEmailMoreThenOne",
				CreatedInPackageId = new Guid("d702c996-3cae-4e74-a7fe-414987972104"),
				CreatedInSchemaUId = new Guid("1b6d391b-284d-43bd-8069-c889c1488d04"),
				ModifiedInSchemaUId = new Guid("1b6d391b-284d-43bd-8069-c889c1488d04")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1b6d391b-284d-43bd-8069-c889c1488d04"));
		}

		#endregion

	}

	#endregion

}

