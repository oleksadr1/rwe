namespace challengeapp2
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectTwoPositiveScoresShouldCorrectResult()
        {
            //arrange
            var employee1 = new Employee("Kuba", "Majewski", 25);
            employee1.AddScore(6);
            employee1.AddScore(7);
            //act
            var result = employee.Result;
            //assert 
            Assert.AreEqual(13, result);




        }
        [Test]
        public void WhenEmployeeCollectTwoNegativeScores_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Natalia", "Majewski", 34);
            employee.AddScore(-3);
            employee.AddScore(-7);
            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(-10, result);

        }


        [Test]
        public void WhenEmployeeCollectTwoPositiveScores_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Paulina", "Majewski", 42);
            employee.AddScore(-3);
            employee.AddScore(9);
            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(0, result);

        }

    }   }    