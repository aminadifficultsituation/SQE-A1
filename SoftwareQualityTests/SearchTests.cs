using Xunit;
using SoftwareQualityProjectLib;

namespace SoftwareQualityTests
{
    public class SearchTests
    {
        private readonly SearchAlgorithms search = new SearchAlgorithms();
        private readonly int[] arr = {1, 3, 5, 6, 8};

        [Fact]
        public void BinarySearch_Found() => Assert.Equal(3, search.BinarySearch(6, arr));

        [Fact]
        public void BinarySearch_NotFound() => Assert.Equal(-1, search.BinarySearch(4, arr));

        [Fact]
        public void LinearSearch_Found() => Assert.Equal(0, search.LinearSearch(1, arr));

        [Fact]
        public void LinearSearch_NotFound() => Assert.Equal(-1, search.LinearSearch(4, arr));

        [Fact]
        public void JumpSearch_Found() => Assert.Equal(4, search.JumpSearch(8, arr));

        [Fact]
        public void JumpSearch_NotFound() => Assert.Equal(-1, search.JumpSearch(10, arr));
    }
}
//meow