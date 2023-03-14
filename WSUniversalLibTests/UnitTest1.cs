using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;

namespace WSUniversalLibTests
{
	[TestClass]
	public class MaterialCalculatorTests
	{
		[TestMethod]
		public void TestCalculateRequiredMaterial_Type1_Material1()
		{
			int count = 5;
			double width = 2.0;
			double length = 3.0;
			string material_type = "Material 1";
			string product_type = "Type 1";
			int expected = 231;

			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void TestCalculateRequiredMaterial_Type2_Material2()
		{
			int count = 10;
			double width = 1.5;
			double length = 2.5;
			string material_type = "Material 2";
			string product_type = "Type 2";
			int expected = 819;

			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void TestCalculateRequiredMaterial_InvalidProductType()
		{
			int count = 5;
			double width = 2.0;
			double length = 3.0;
			string material_type = "Material 1";
			string product_type = "Invalid Type";
			int expected = -1;

			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void TestCalculateRequiredMaterial_InvalidMaterialType()
		{
			int count = 5;
			double width = 2.0;
			double length = 3.0;
			string material_type = "Invalid Material";
			string product_type = "Type 1";
			int expected = -1;

			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void CalculateRequiredMaterial_InvalidMaterialType_ReturnsNegativeOne()
		{
			// Arrange
			int count = 3;
			double width = 5.0;
			double length = 6.0;
			string materialType = "Invalid";
			string productType = "Type 1";
			int expected = -1;

			// Act
			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, materialType, productType);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestCalculateRequiredMaterial_ZeroCount()
		{
			int count = 0;
			double width = 2.0;
			double length = 3.0;
			string material_type = "Material 1";
			string product_type = "Type 1";
			int expected = 0;

			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			Assert.AreEqual(expected, actual);
		}

		//Сложные

		[TestMethod]
		public void TestCalculateRequiredMaterial_InvalidMaterialTypeWithCorrectOtherParams()
		{
			int count = 5;
			double width = 2.0;
			double length = 3.0;
			string material_type = "Invalid Material";
			string product_type = "Type 1";
			int expected = -1;

			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void TestCalculateRequiredMaterial_InvalidProductTypeWithCorrectOtherParams()
		{
			int count = 5;
			double width = 2.0;
			double length = 3.0;
			string material_type = "Material 1";
			string product_type = "Invalid Type";
			int expected = -1;

			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void TestCalculateRequiredMaterial_ZeroCountWithCorrectOtherParams()
		{
			int count = 0;
			double width = 2.0;
			double length = 3.0;
			string material_type = "Material 1";
			string product_type = "Type 1";
			int expected = 0;

			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void TestCalculateRequiredMaterial_InvalidWidthWithCorrectOtherParams()
		{
			int count = 5;
			double width = -2.0;
			double length = 3.0;
			string material_type = "Material 1";
			string product_type = "Type 1";
			int expected = -1;

			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void TestCalculateRequiredMaterial_InvalidLengthWithCorrectOtherParams()
		{
			int count = 5;
			double width = 2.0;
			double length = -3.0;
			string material_type = "Material 1";
			string product_type = "Type 1";
			int expected = -1;

			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void CalculateRequiredMaterial_InvalidProductAndMaterialType_ReturnsMinusOne()
		{
			// Arrange
			int count = 10;
			double width = 2.5;
			double length = 3.5;
			string product_type = "Type 4"; // Несуществующий тип продукта
			string material_type = "Material 3"; // Несуществующий тип материала

			// Act
			int result = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			// Assert
			Assert.AreEqual(-1, result);
		}


		[TestMethod]
		public void CalculateRequiredMaterial_ZeroArea_ReturnsZero()
		{
			// Arrange
			int count = 10;
			double width = 0;
			double length = 0;
			string product_type = "Type 1";
			string material_type = "Material 1";

			// Act
			int result = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			// Assert
			Assert.AreEqual(0, result);
		}


		[TestMethod]
		public void CalculateRequiredMaterial_ZeroCount_ReturnsZero()
		{
			// Arrange
			int count = 0;
			double width = 2.5;
			double length = 3.5;
			string product_type = "Type 1";
			string material_type = "Material 1";

			// Act
			int result = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			// Assert
			Assert.AreEqual(0, result);
		}


		[TestMethod]
		public void CalculateRequiredMaterial_SmallProductSize_ReturnsExpectedResult()
		{
			// Arrange
			int count = 1;
			double width = 0.1;
			double length = 0.2;
			string product_type = "Type 1";
			string material_type = "Material 1";

			// Act
			int result = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			// Assert
			Assert.AreEqual(5, result);
		}


		[TestMethod]
		public void CalculateRequiredMaterial_LargeCount_ReturnsExpectedResult()
		{
			// Arrange
			int count = int.MaxValue;
			double width = 2.5;
			double length = 3.5;
			string product_type = "Type 1";
			string material_type = "Material 1";

			// Act
			int result = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			// Assert
			Assert.AreEqual(int.MaxValue, result);
		}

	}
}