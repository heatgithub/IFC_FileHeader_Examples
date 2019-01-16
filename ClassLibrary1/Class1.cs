using Autodesk.AutoCAD.Runtime;
using GeometryGym.Ifc;
using System.IO;

namespace ClassLibrary1
{
    public class Class1
    {
		[CommandMethod("ifcout")]
		public void Main()
		{
			DatabaseIfc db = new DatabaseIfc(ModelView.Ifc2x3Coordination);

			IfcSite site = new IfcSite(db, "Default Site");
			IfcProject project = new IfcProject(site, "Default Project", IfcUnitAssignment.Length.Metre) { };
			IfcBuilding building = new IfcBuilding(site, "Default Building");
			IfcBuildingStorey buildingStorey = new IfcBuildingStorey(building, "SitePlan", 0.0);

			string currentDir = Path.GetDirectoryName(System.Environment.CurrentDirectory);
			db.WriteFile(Path.Combine(currentDir, "ClassLibrary1.ifc"));
		}

	}
}
