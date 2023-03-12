using System;

namespace WSUniversalLib
{
	public class MaterialCalculator
	{
		public static int CalculateRequiredMaterial(int count, double width, double length, string material_type, string product_type)
		{
			double area = width * length;
			double coefficient;

			switch (product_type)
			{
				case "Type 1":
					coefficient = 1.1;
					break;
				case "Type 2":
					coefficient = 2.5;
					break;
				case "Type 3":
					coefficient = 8.43;
					break;
				default:
					return -1;
			}

			double materialWaste;
			switch (material_type)
			{
				case "Material 1":
					materialWaste = 0.003;
					break;
				case "Material 2":
					materialWaste = 0.0012;
					break;
				default:
					return -1;
			}

			double requiredMaterial = count * area * coefficient / (1 - materialWaste);
			return (int)Math.Ceiling(requiredMaterial);
		}
	}
}