using CompanyProject.Tools;

namespace CompanyProject.Tests
{
    public class PasswordUtilTests
    {
        [Fact]
        public void CreatePasswordTest()
        {
            // given
            string password = "test1234";
            int exptectedHashLength = 68;

            //when
            string hash = PasswordUtil.HashPassword(password);

            // then
            Assert.NotNull(hash);
            Assert.EndsWith("==", hash);
            Assert.Equal(exptectedHashLength, hash.Length);
        }

        [Fact]
        public void CreateNullPasswordTest()
        {
            Assert.Throws<ArgumentNullException>(() => PasswordUtil.HashPassword(null));
        }

        [Fact]
        public void CreateEmptyPasswordTest()
        {
            string password = "";
            int exptectedHashLength = 68;
            string hash = PasswordUtil.HashPassword(password);
            Assert.NotNull(hash);
            Assert.EndsWith("==", hash);
            Assert.Equal(exptectedHashLength, hash.Length);
        }
    }
}