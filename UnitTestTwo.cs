using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListAndTDD
{
    class UnitTestTwo
    {
        [TestMethod]
        public void CreateACustomList_CheckC_Sharp_RemoveMethod()

        {
            //Arrange
            CustomList list = new CustomList();
            string name1 = "Packers";
            string name2 = "Browns";
            string name3 = "SeaHawks";
            int expected = 2;
            int actual;

            //Act
            list.Add(name1);
            list.Add(name2);
            list.Add(name3);
            list.Remove(name1);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
