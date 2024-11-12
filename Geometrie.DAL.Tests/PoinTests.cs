namespace Geometrie.DAL.Tests
{
    public class PoinTests
    {
        [Fact]
        public void Point_Constructor()
        {
            //on teste le premier constructeur de la classe Point
            //un test se passe en 3 phase : Arrange, Act, Assert
            var point = new Point(1, 2, new DateTime(2021, 11, 12));

            //Assert : vérification des résultats
            Assert.Equal(1, point.X);
            Assert.Equal(2, point.Y);
            Assert.Equal(new DateTime(2021, 11, 12), point.DateDeCreation);
        }

        [Fact]
        public void Point_Constructor_2()
        {
            //Arrange
            var point = new Point(1, 2, 3, new DateTime(2021, 11, 12), new DateTime(2021, 11, 13), null);

            //Assert
            Assert.Equal(1, point.Id);
            Assert.Equal(2, point.X);
            Assert.Equal(3, point.Y);
            Assert.Equal(new DateTime(2021, 11, 12), point.DateDeCreation);
            Assert.Equal(new DateTime(2021, 11, 13), point.DateDeModification);
            Assert.Null(point.Polygone);
        }


        //fait la même chose avec des theory
        [Theory]
        [InlineData(1, 2, 3, "2021-11-12", "2021-11-13")]
        [InlineData(4, 5, 6, "2021-11-14", "2021-11-15")]

        public void Point_Constructor_3(int id, int x, int y, string dateDeCreation, string dateDeModification)
        {
            var polygone = new Polygone();

            //Arrange
            var point = new Point(id, x, y, DateTime.Parse(dateDeCreation), DateTime.Parse(dateDeModification), polygone);

            //Assert
            Assert.Equal(id, point.Id);
            Assert.Equal(x, point.X);
            Assert.Equal(y, point.Y);
            Assert.Equal(DateTime.Parse(dateDeCreation), point.DateDeCreation);
            Assert.Equal(DateTime.Parse(dateDeModification), point.DateDeModification);
            Assert.Equal(polygone, point.Polygone);
        }
    }
}