namespace Largest_Series_Product
{
    public class LargestSeriesProductTests
    {
        [Fact]
        public void Finds_the_largest_product_if_span_equals_length()
        {
            Assert.Equal(18, Ejercicio.GetLargestProduct("29", 2));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Can_find_the_largest_product_of_2_with_numbers_in_order()
        {
            Assert.Equal(72, Ejercicio.GetLargestProduct("0123456789", 2));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Can_find_the_largest_product_of_2()
        {
            Assert.Equal(48, Ejercicio.GetLargestProduct("576802143", 2));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Can_find_the_largest_product_of_3_with_numbers_in_order()
        {
            Assert.Equal(504, Ejercicio.GetLargestProduct("0123456789", 3));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Can_find_the_largest_product_of_3()
        {
            Assert.Equal(270, Ejercicio.GetLargestProduct("1027839564", 3));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Can_find_the_largest_product_of_5_with_numbers_in_order()
        {
            Assert.Equal(15120, Ejercicio.GetLargestProduct("0123456789", 5));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Can_get_the_largest_product_of_a_big_number()
        {
            Assert.Equal(23520, Ejercicio.GetLargestProduct("73167176531330624919225119674426574742355349194934", 6));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Reports_zero_if_the_only_digits_are_zero()
        {
            Assert.Equal(0, Ejercicio.GetLargestProduct("0000", 2));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Reports_zero_if_all_spans_include_zero()
        {
            Assert.Equal(0, Ejercicio.GetLargestProduct("99099", 3));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Rejects_span_longer_than_string_length()
        {
            Assert.Throws<ArgumentException>(() => Ejercicio.GetLargestProduct("123", 4));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Rejects_empty_string_and_nonzero_span()
        {
            Assert.Throws<ArgumentException>(() => Ejercicio.GetLargestProduct("", 1));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Rejects_invalid_character_in_digits()
        {
            Assert.Throws<ArgumentException>(() => Ejercicio.GetLargestProduct("1234a5", 2));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Rejects_negative_span()
        {
            Assert.Throws<ArgumentException>(() => Ejercicio.GetLargestProduct("12345", -1));
        }
    }
}