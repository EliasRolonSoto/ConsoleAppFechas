namespace TestProjectFecha
{
    public class UnitTest1
    {
        [Fact]
        public void Edad()
        {
            var nacimiento = new DateTime(1995, 12, 01);

            var hoy = new DateTime();

            hoy = DateTime.Now;

            //var edad = (hoy.Subtract(value: nacimiento).days / 365);

            var dif = hoy.Subtract(value: nacimiento);

            var edad = dif.Days;

            edad = edad / 365;

            Assert.Equal(27, edad);

        }
        [Fact]
        public void NacimientoString()
        {
            var nacimiento = new DateTime(1995, 12, 01, 17, 52, 0);

            //var f1 = new DateTime(2012, 8, 20, 17, 52, 0, 0);
            //Assert.Equal("lun. 20 de agosto de 2012 a las 17:52", f1.ToString("...."));

            const string FORMAT = "ddd d \\de MMMM \\de yyyy \\a la\\s HH:mm";

            const string FORMAT2 = @"ddd d \de MMMM \de yyyy \a la\s HH:mm";

            Assert.Equal("vie. 1 de diciembre de 1995 a las 17:52", nacimiento.ToString(FORMAT));

            Assert.Equal("vie. 1 de diciembre de 1995 a las 17:52", nacimiento.ToString(FORMAT2));

        }
    }
}