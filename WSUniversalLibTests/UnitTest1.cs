using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;

namespace WSUniversalLibTests
{
	[TestClass]
	public class MaterialCalculatorTests
	{
		[TestMethod]
		public void CalculateRequiredMaterial_Type1Material1_ReturnsExpectedValue()
		{
			// Arrange
			int count = 10;
			double width = 2.5;
			double length = 3.5;
			string materialType = "Material 1";
			string productType = "Type 1";
			int expected = 159;

			// Act
			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, materialType, productType);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CalculateRequiredMaterial_Type2Material1_ReturnsExpectedValue()
		{
			// Arrange
			int count = 5;
			double width = 4.5;
			double length = 6.0;
			string materialType = "Material 1";
			string productType = "Type 2";
			int expected = 375;

			// Act
			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, materialType, productType);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CalculateRequiredMaterial_Type3Material1_ReturnsExpectedValue()
		{
			// Arrange
			int count = 2;
			double width = 10.0;
			double length = 15.0;
			string materialType = "Material 1";
			string productType = "Type 3";
			int expected = 632;

			// Act
			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, materialType, productType);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CalculateRequiredMaterial_InvalidProductType_ReturnsNegativeOne()
		{
			// Arrange
			int count = 1;
			double width = 2.0;
			double length = 3.0;
			string materialType = "Material 2";
			string productType = "Invalid";
			int expected = -1;

			// Act
			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, materialType, productType);

			// Assert
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
		public void CalculateRequiredMaterial_ValidData_ReturnsCorrectAmount()
		{
			// Arrange
			int count = 5;
			double width = 2.5;
			double length = 3.5;
			string materialType = "Material 1";
			string productType = "Type 1";

			// Act
			int result = MaterialCalculator.CalculateRequiredMaterial(count, width, length, materialType, productType);

			// Assert
			Assert.AreEqual(490, result);
		}

		[TestMethod]
		public void CalculateRequiredMaterial_NegativeCount_ReturnsNegativeOne()
		{
			// Arrange
			int count = -5;
			double width = 2.5;
			double length = 3.5;
			string materialType = "Material 1";
			string productType = "Type 1";

			// Act
			int result = MaterialCalculator.CalculateRequiredMaterial(count, width, length, materialType, productType);

			// Assert
			Assert.AreEqual(-1, result);
		}

		[TestMethod]
		public void CalculateRequiredMaterial_ZeroWidth_ReturnsNegativeOne()
		{
			// Arrange
			int count = 5;
			double width = 0;
			double length = 3.5;
			string materialType = "Material 1";
			string productType = "Type 1";

			// Act
			int result = MaterialCalculator.CalculateRequiredMaterial(count, width, length, materialType, productType);

			// Assert
			Assert.AreEqual(-1, result);
		}

		[TestMethod]
		public void CalculateRequiredMaterial_InvalidMaterialType_ReturnsMinusOne()
		{
			// Arrange
			int count = 10;
			double width = 2.5;
			double length = 5.0;
			string materialType = "Invalid Type";
			string productType = "Type 1";
			int expected = -1;

			// Act
			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, materialType, productType);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CalculateRequiredMaterial_InvalidProductType_ReturnsMinusOne()
		{
			// Arrange
			int count = 10;
			double width = 2.5;
			double length = 5.0;
			string materialType = "Material 1";
			string productType = "Invalid Type";
			int expected = -1;

			// Act
			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, materialType, productType);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CalculateRequiredMaterial_ValidParameters_ReturnsCorrectValue()
		{
			// Arrange
			int count = 10;
			double width = 2.5;
			double length = 5.0;
			string materialType = "Material 1";
			string productType = "Type 1";
			int expected = 267;

			// Act
			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, materialType, productType);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CalculateRequiredMaterial_ZeroArea_ReturnsZero()
		{
			// Arrange
			int count = 10;
			double width = 0.0;
			double length = 0.0;
			string materialType = "Material 1";
			string productType = "Type 1";
			int expected = 0;

			// Act
			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, materialType, productType);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CalculateRequiredMaterial_NegativeCount_ReturnsZero()
		{
			// Arrange
			int count = -10;
			double width = 2.5;
			double length = 5.0;
			string materialType = "Material 1";
			string productType = "Type 1";
			int expected = 0;

			// Act
			int actual = MaterialCalculator.CalculateRequiredMaterial(count, width, length, materialType, productType);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Test_RequiredMaterialForType3WithInvalidMaterialType_ReturnsMinusOne()
		{
			// Arrange
			int count = 5;
			double width = 1.5;
			double length = 2.5;
			string material_type = "Invalid Material Type";
			string product_type = "Type 3";

			// Act
			int result = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			// Assert
			Assert.AreEqual(-1, result);
		}

		[TestMethod]
		public void Test_RequiredMaterialForType1WithMaterial1AndNegativeCount_ReturnsMinusOne()
		{
			// Arrange
			int count = -5;
			double width = 2.0;
			double length = 3.0;
			string material_type = "Material 1";
			string product_type = "Type 1";

			// Act
			int result = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			// Assert
			Assert.AreEqual(-1, result);
		}

		[TestMethod]
		public void Test_RequiredMaterialForType2WithMaterial2AndZeroWidth_ReturnsMinusOne()
		{
			// Arrange
			int count = 10;
			double width = 0.0;
			double length = 5.0;
			string material_type = "Material 2";
			string product_type = "Type 2";

			// Act
			int result = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			// Assert
			Assert.AreEqual(-1, result);
		}

		[TestMethod]
		public void Test_RequiredMaterialForType1WithMaterial2AndLargeCount_ReturnsValidResult()
		{
			// Arrange
			int count = 1000;
			double width = 2.0;
			double length = 3.0;
			string material_type = "Material 2";
			string product_type = "Type 1";

			// Act
			int result = MaterialCalculator.CalculateRequiredMaterial(count, width, length, material_type, product_type);

			// Assert
			Assert.IsTrue(result > 0);
		}

	}
}