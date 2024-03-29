﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyListClass;

namespace MyListTests
{
    [TestClass]
    public class CustomListTest
    {
        //--------------------------------Add Method---------------------------------------
        [TestMethod]
        public void HaveArrayWithoutElementsOnIt_UseAddMethods_ReturnArrayWithThem()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int expected = value1;
            int actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            actual = NewCustomList.WorkingArray[0];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithoutElementsOnIt_UseAddMethods_ReturnArrayWithThemString()
        {
            CustomList<string> NewCustomList = new CustomList<string>();
            string value1 = "Hello";
            string expected = value1;
            string actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            actual = NewCustomList.WorkingArray[0];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithoutElementsOnIt_UseAddMethods2_ReturnArrayWithThem2()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int value2 = 5;
            int expected = value2;
            int actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);
            actual = NewCustomList.WorkingArray[1];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithoutElementsOnIt_UseAddMethods4_ReturnArrayWithThem4()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int expected = value4;
            int actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);
            NewCustomList.Add(value3);
            NewCustomList.Add(value4);
            actual = NewCustomList.WorkingArray[3];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithoutElementsOnIt_UseAddMethods4_ReturnArrayCapacity()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int expected = 8;
            int actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);
            NewCustomList.Add(value3);
            NewCustomList.Add(value4);
            actual = NewCustomList.Capacity;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithoutStringElementsOnIt_UseAddMethods4_ReturnArrayCapacity()
        {
            CustomList<string> NewCustomList = new CustomList<string>();
            string value1 = "Hello";
            string value2 = "How";
            string value3 = "Are";
            string value4 = "You";
            int expected = 8;
            int actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);
            NewCustomList.Add(value3);
            NewCustomList.Add(value4);
            actual = NewCustomList.Capacity;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithoutElementsOnIt_UseAddMethods8_ReturnArrayCapacity()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int expected = 16;
            int actual;

            //act - act on the method under test
            for (int i = 0; i < 8; i++)
            {
                NewCustomList.Add(value1);
            }
            actual = NewCustomList.Capacity;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithoutElementsOnIt_UseAddMethods16_ReturnArrayCapacity()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int expected = 32;
            int actual;

            //act - act on the method under test
            for (int i = 0; i < 17; i++)
            {
                NewCustomList.Add(value1);
            }

            actual = NewCustomList.Capacity;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithoutElementsOnIt_UseAddMethods16_ReturnArrayIndexAt17()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int value2 = 20;
            int expected = value2;
            int actual;

            //act - act on the method under test
            for (int i = 0; i < 17; i++)
            {
                NewCustomList.Add(value1);
            }
            NewCustomList.Add(value2);

            actual = NewCustomList.WorkingArray[17];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithoutElementsOnIt_UseAddMethods16_ReturnStringArrayIndexAt17()
        {
            CustomList<string> NewCustomList = new CustomList<string>();
            string value1 = "Hello";
            string value2 = "Whatsup";
            string expected = value2;
            string actual;

            //act - act on the method under test
            for (int i = 0; i < 17; i++)
            {
                NewCustomList.Add(value1);
            }
            NewCustomList.Add(value2);

            actual = NewCustomList.WorkingArray[17];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        //----------------------------------Count--------------------------------------------
        [TestMethod]
        public void CountStartsAtZero_UseAddMethods_ReturnIncreasedCount()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int expected = 2;
            int actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            NewCustomList.Add(value1);
            actual = NewCustomList.Count;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        //---------------------------------Capacity---------------------------------------------
        [TestMethod]
        public void CapacityStartsAtFour_UseAddMethods_ReturnIncreasedCapacity()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int expected = 8;
            int actual;

            //act - act on the method under test
            for (int i = 0; i < 6; i++)
            {
                NewCustomList.Add(value1);
            }
            actual = NewCustomList.Capacity;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        //--------------------------------RemoveAt Method----------------------------------------
        [TestMethod]
        public void HaveArrayWithElementsOnIt_UseRemoveAtMethod_ReturnArrayWithoutIt()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int value2 = 9;
            int expected = value1;
            int actual;

            //act - act on the method under test
            for (int i = 0; i < 10; i++)
            {
                NewCustomList.Add(value1);
                NewCustomList.Add(value2);

            }
            NewCustomList.Add(8);
            NewCustomList.RemoveAt(5);
            actual = NewCustomList.WorkingArray[5];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveALotOfArrayWithElementsOnIt_UseRemoveAtMethod_ReturnArrayWithoutIt()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int value2 = 9;
            int expected = value2;
            int actual;

            //act - act on the method under test
            for (int i = 0; i < 60; i++)
            {
                NewCustomList.Add(value1);
                NewCustomList.Add(value2);

            }
            NewCustomList.Add(8);
            NewCustomList.RemoveAt(50);
            actual = NewCustomList.WorkingArray[50];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithStringElementsOnIt_UseRemoveAtMethod_ReturnArrayWithoutIt()
        {
            CustomList<string> NewCustomList = new CustomList<string>();
            string value1 = "Hello";
            string value2 = "Whatsup";
            string expected = value2;
            string actual;

            //act - act on the method under test
            for (int i = 0; i < 60; i++)
            {
                NewCustomList.Add(value1);
                NewCustomList.Add(value2);

            }
            NewCustomList.RemoveAt(50);
            actual = NewCustomList.WorkingArray[50];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        //--------------------------------Remove Method------------------------------------------
        [TestMethod]
        public void HaveArrayWithElementsOnIt_UseRemoveMethods_ReturnArrayCount()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 12;
            int expected = 7;
            int actual;

            //act - act on the method under test
            for (int i = 0; i < 10; i++)
            {
                NewCustomList.Add(value1);
            }
            for (int i = 0; i < 3; i++)
            {
                NewCustomList.Remove(value1);
            }

            actual = NewCustomList.Count;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
       [TestMethod]
        public void HaveArrayWithElementsOnIt_UseRemoveMethodOnNullElement_ReturnCount()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 12;
            int valueNonExistant = 70;
            int expected = 10;
            int actual;

            //act - act on the method under test
            for (int i = 0; i < 10; i++)
            {
                NewCustomList.Add(value1);
            }

            NewCustomList.Remove(valueNonExistant);
            

            actual = NewCustomList.Count;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithElementsOnIt_UseRemoveMethodOnNullElement_ReturnFirstElement()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int valueNonExistant = 70;
            int expected = 0;
            int actual;

            //act - act on the method under test
            for (int i = 0; i < 10; i++)
            {
                NewCustomList.Add(i);
            }

            NewCustomList.Remove(valueNonExistant);


            actual = NewCustomList[0];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithStringElementsOnIt_UseRemoveMethods_ReturnArrayCount()
        {
            CustomList<string> NewCustomList = new CustomList<string>();
            string value1 = "Hello";
            int expected = 7;
            int actual;

            //act - act on the method under test
            for (int i = 0; i < 10; i++)
            {
                NewCustomList.Add(value1);
            }
            for (int i = 0; i < 3; i++)
            {
                NewCustomList.Remove(value1);
            }

            actual = NewCustomList.Count;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithElementsOnIt_UseRemoveMethod_ReturnArrayWithoutThem()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int expected = 0;
            int actual;

            //act - act on the method under test
            for (int i = 0; i < 10; i++)
            {
                NewCustomList.Add(value1);
            }
            for (int i = 0; i < 10; i++)
            {
                NewCustomList.Remove(value1);
            }

            actual = NewCustomList.WorkingArray[0];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithElementsOnIt_UseRemoveMethod_ReturnArrayWithoutSpecific()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int expected = 11;
            int actual;

            //act - act on the method under test
            for (int i = 0; i < 10; i++)
            {
                NewCustomList.Add(value1 + i);
            }

            NewCustomList.Remove(10);


            actual = NewCustomList.WorkingArray[3];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        //--------------------------------ToString Method-----------------------------------------
        [TestMethod]
        public void HaveArrayWithElementsOnIt_UseToStringMethod_ReturnStringOfElements()
        {
            CustomList<string> NewCustomList = new CustomList<string>();
            string value1 = "Hello";
            string value2 = "Bob";
            string expected = "Hello Bob";
            string actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);

            actual = NewCustomList.ToString();

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWith5ElementsOnIt_UseToStringMethod_ReturnStringOfElements()
        {
            CustomList<string> NewCustomList = new CustomList<string>();
            string value1 = "Hello";
            string value2 = "Bob";
            string value3 = "How";
            string value4 = "Are";
            string value5 = "You";
            string expected = "Hello Bob How Are You";
            string actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);
            NewCustomList.Add(value3);
            NewCustomList.Add(value4);
            NewCustomList.Add(value5);

            actual = NewCustomList.ToString();

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWith5IntsOnIt_UseToStringMethod_ReturnStringOfElements()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            string expected = "0 1 2 3 4 5 6";
            string actual;

            //act - act on the method under test
            for (int i = 0; i < 7; i++)
            {
                NewCustomList.Add(i);
            }

            actual = NewCustomList.ToString();

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        //------------------------------------OverLoad the + operator-----------------------------
        [TestMethod]
        public void HaveTwoLists_UseOverloadedOperatorToAddMerge_ReturnTheCount()
        {
            CustomList<int> NewCustomList1 = new CustomList<int>();
            CustomList<int> NewCustomList2 = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            expectedList.Add(1);
            expectedList.Add(3);
            expectedList.Add(5);
            expectedList.Add(2);
            expectedList.Add(1);
            expectedList.Add(6);
            CustomList<int> JoinedCustomList;

            int expected = 6;
            int actual;

            //act - act on the method under test            
            NewCustomList1.Add(1);
            NewCustomList1.Add(3);
            NewCustomList1.Add(5);
            NewCustomList2.Add(2);
            NewCustomList2.Add(1);
            NewCustomList2.Add(6);

            JoinedCustomList = NewCustomList1 + NewCustomList2;
            actual = JoinedCustomList.Count;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveTwoBigLists_UseOverloadedOperatorToAddMerge_ReturnTheCount()
        {
            CustomList<int> NewCustomList1 = new CustomList<int>();
            CustomList<int> NewCustomList2 = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            for (int i = 0; i < 50; i++)
            {
                expectedList.Add(i);
            }

            CustomList<int> JoinedCustomList;

            int expected = 50;
            int actual;

            //act - act on the method under test 
            for (int i = 0; i < 50; i++)
            {
                NewCustomList1.Add(i);
            }

            JoinedCustomList = NewCustomList1 + NewCustomList2;
            actual = JoinedCustomList.Count;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveTwoBigLists_UseOverloadedOperatorToAddMerge_ReturnTheCombinedCount()
        {
            CustomList<int> NewCustomList1 = new CustomList<int>();
            CustomList<int> NewCustomList2 = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            for (int i = 0; i < 50; i++)
            {
                expectedList.Add(i);
            }

            CustomList<int> JoinedCustomList;

            int expected = 50;
            int actual;

            //act - act on the method under test 
            for (int i = 0; i < 25; i++)
            {
                NewCustomList1.Add(i);
            }
            for (int i = 0; i < 25; i++)
            {
                NewCustomList1.Add(i);
            }

            JoinedCustomList = NewCustomList1 + NewCustomList2;
            actual = JoinedCustomList.Count;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveTwoLists_UseOverloadedOperatorToAddMerge_ReturnOneListOfAllElements()
        {
            CustomList<int> NewCustomList1 = new CustomList<int>();
            CustomList<int> NewCustomList2 = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            expectedList.Add(1);
            expectedList.Add(3);
            expectedList.Add(5);
            expectedList.Add(2);
            expectedList.Add(1);
            expectedList.Add(6);
            CustomList<int> JoinedCustomList;
            bool expected = true;
            bool actual;

            int[] expectedArr = { 1, 3, 5, 2, 1, 6, 0, 0 };
            int[] actualArr;

            //act - act on the method under test            
            NewCustomList1.Add(1);
            NewCustomList1.Add(3);
            NewCustomList1.Add(5);
            NewCustomList2.Add(2);
            NewCustomList2.Add(1);
            NewCustomList2.Add(6);

            JoinedCustomList = NewCustomList1 + NewCustomList2;
            actualArr = JoinedCustomList.WorkingArray;
            if (expectedArr.SequenceEqual(actualArr))
            {
                actual = true;
            }
            else
            {
                actual = false;
            }

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveTwoBigLists_UseOverloadedOperatorToAddMerge_ReturnOneListOfAllElements()
        {
            CustomList<int> NewCustomList1 = new CustomList<int>();
            CustomList<int> NewCustomList2 = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            for (int i = 0; i < 50; i++)
            {
                expectedList.Add(i);
            }
            CustomList<int> JoinedCustomList;
            bool expected = true;
            bool actual;

            int[] expectedArr;
            int[] actualArr;

            //act - act on the method under test            
            for (int i = 0; i < 25; i++)
            {
                NewCustomList1.Add(i);
            }
            for (int i = 0; i < 25; i++)
            {
                NewCustomList2.Add(i);
            }

            JoinedCustomList = NewCustomList1 + NewCustomList2;
            expectedArr = JoinedCustomList.WorkingArray;
            actualArr = JoinedCustomList.WorkingArray;
            if (expectedArr.SequenceEqual(actualArr))
            {
                actual = true;
            }
            else
            {
                actual = false;
            }

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        //------------------------------------OverLoad the - operator------------------------------
        [TestMethod]
        public void HaveTwoLists3_UseMinusOverloadedOperatorToAddMerge_ReturnUniqueElementsForFirst()
        {
            CustomList<int> NewCustomList1 = new CustomList<int>();
            CustomList<int> NewCustomList2 = new CustomList<int>();
            CustomList<int> JoinedCustomList;
            bool expected = true;
            bool actual;

            int[] expectedArr = { 3, 5, 0, 0 };
            int[] actualArr;

            //act - act on the method under test            
            NewCustomList1.Add(1);
            NewCustomList1.Add(3);
            NewCustomList1.Add(5);

            NewCustomList2.Add(2);
            NewCustomList2.Add(1);
            NewCustomList2.Add(6);

            JoinedCustomList = NewCustomList1 - NewCustomList2;
            actualArr = JoinedCustomList.WorkingArray;

            if (expectedArr.SequenceEqual(actualArr))
            {
                actual = true;
            }
            else
            {
                actual = false;
            }

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveTwoLists3_UseMinusOverloadedOperatorToAddMergeWithNullNumbers_ReturnUniqueElementsForFirst()
        {
            CustomList<int> NewCustomList1 = new CustomList<int>();
            CustomList<int> NewCustomList2 = new CustomList<int>();
            CustomList<int> JoinedCustomList;
            bool expected = true;
            bool actual;

            int[] expectedArr = { 3, 5, 0, 0 };
            int[] actualArr;

            //act - act on the method under test            
            NewCustomList1.Add(1);
            NewCustomList1.Add(3);
            NewCustomList1.Add(5);

            NewCustomList2.Add(2);
            NewCustomList2.Add(1);
            NewCustomList2.Add(6);
            NewCustomList2.Add(89);

            JoinedCustomList = NewCustomList1 - NewCustomList2;
            actualArr = JoinedCustomList.WorkingArray;

            if (expectedArr.SequenceEqual(actualArr))
            {
                actual = true;
            }
            else
            {
                actual = false;
            }

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveTwoLists6_UseMinusOverloadedOperatorToAddMerge_ReturnUniqueElementsForFirst()
        {
            CustomList<int> NewCustomList1 = new CustomList<int>();
            CustomList<int> NewCustomList2 = new CustomList<int>();
            CustomList<int> JoinedCustomList;
            bool expected = true;
            bool actual;

            int[] expectedArr = { 2, 5, 0, 0 };
            int[] actualArr;

            //act - act on the method under test            
            NewCustomList1.Add(1);
            NewCustomList1.Add(2);
            NewCustomList1.Add(3);
            NewCustomList1.Add(4);
            NewCustomList1.Add(5);
            NewCustomList1.Add(6);

            NewCustomList2.Add(1);
            NewCustomList2.Add(1);
            NewCustomList2.Add(3);
            NewCustomList2.Add(4);
            NewCustomList2.Add(6);
            NewCustomList2.Add(6);

            JoinedCustomList = NewCustomList1 - NewCustomList2;
            actualArr = JoinedCustomList.WorkingArray;

            if (expectedArr.SequenceEqual(actualArr))
            {
                actual = true;
            }
            else
            {
                actual = false;
            }

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        //------------------------------------Zip Method-----------------------------------
        [TestMethod]
        public void HaveTwoLists3_UseZipToMerge_ReturnZippedList()
        {
            CustomList<int> NewCustomList1 = new CustomList<int>();
            CustomList<int> NewCustomList2 = new CustomList<int>();
            bool expected = true;
            bool actual;

            int[] expectedArr = { 1, 1, 2, 1, 3, 3, 0, 0 };
            int[] actualArr;

            //act - act on the method under test            
            NewCustomList1.Add(1);
            NewCustomList1.Add(2);
            NewCustomList1.Add(3);

            NewCustomList2.Add(1);
            NewCustomList2.Add(1);
            NewCustomList2.Add(3);

            NewCustomList1.Zip(NewCustomList2);
            actualArr = NewCustomList1.WorkingArray;

            if (expectedArr.SequenceEqual(actualArr))
            {
                actual = true;
            }
            else
            {
                actual = false;
            }

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveTwoStringLists3_UseZipToMerge_ReturnZippedList()
        {
            CustomList<string> NewCustomList1 = new CustomList<string>();
            CustomList<string> NewCustomList2 = new CustomList<string>();
            bool expected = true;
            bool actual;

            string[] expectedArr = { "Hey", "Man", "Yo", "Dude", "Sup", "Guy", null, null };
            string[] actualArr;

            //act - act on the method under test            
            NewCustomList1.Add("Hey");
            NewCustomList1.Add("Yo");
            NewCustomList1.Add("Sup");

            NewCustomList2.Add("Man");
            NewCustomList2.Add("Dude");
            NewCustomList2.Add("Guy");

            NewCustomList1.Zip(NewCustomList2);
            actualArr = NewCustomList1.WorkingArray;

            if (expectedArr.SequenceEqual(actualArr))
            {
                actual = true;
            }
            else
            {
                actual = false;
            }

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveTwoUnevenLists3_UseZipToMerge_ReturnZippedList()
        {
            CustomList<int> NewCustomList1 = new CustomList<int>();
            CustomList<int> NewCustomList2 = new CustomList<int>();
            bool expected = true;
            bool actual;

            int[] expectedArr = { 1, 2, 3, 4, 5, 6, 8, 0 };
            int[] actualArr;

            //act - act on the method under test            
            NewCustomList1.Add(1);
            NewCustomList1.Add(3);
            NewCustomList1.Add(5);

            NewCustomList2.Add(2);
            NewCustomList2.Add(4);
            NewCustomList2.Add(6);
            NewCustomList2.Add(8);

            NewCustomList1.Zip(NewCustomList2);
            actualArr = NewCustomList1.WorkingArray;

            if (expectedArr.SequenceEqual(actualArr))
            {
                actual = true;
            }
            else
            {
                actual = false;
            }

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveTwoUnevenLists4_UseZipToMerge_ReturnZippedList()
        {
            CustomList<int> NewCustomList1 = new CustomList<int>();
            CustomList<int> NewCustomList2 = new CustomList<int>();
            bool expected = true;
            bool actual;

            int[] expectedArr = { 1, 2, 3, 4, 5, 6, 8, 9, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] actualArr;

            //act - act on the method under test            
            NewCustomList1.Add(1);
            NewCustomList1.Add(3);
            NewCustomList1.Add(5);

            NewCustomList2.Add(2);
            NewCustomList2.Add(4);
            NewCustomList2.Add(6);
            NewCustomList2.Add(8);
            NewCustomList2.Add(9);

            NewCustomList1.Zip(NewCustomList2);
            actualArr = NewCustomList1.WorkingArray;

            if (expectedArr.SequenceEqual(actualArr))
            {
                actual = true;
            }
            else
            {
                actual = false;
            }

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveTwoLists6_UseZipToMerge_ReturnZippedList()
        {
            CustomList<int> NewCustomList1 = new CustomList<int>();
            CustomList<int> NewCustomList2 = new CustomList<int>();
            bool expected = true;
            bool actual;

            int[] expectedArr = { 1, 1, 2, 1, 3, 3, 1, 1, 1, 2, 3, 3, 0, 0, 0, 0 };
            int[] actualArr;

            //act - act on the method under test            
            NewCustomList1.Add(1);
            NewCustomList1.Add(2);
            NewCustomList1.Add(3);
            NewCustomList1.Add(1);
            NewCustomList1.Add(1);
            NewCustomList1.Add(3);

            NewCustomList2.Add(1);
            NewCustomList2.Add(1);
            NewCustomList2.Add(3);
            NewCustomList2.Add(1);
            NewCustomList2.Add(2);
            NewCustomList2.Add(3);

            NewCustomList1.Zip(NewCustomList2);
            actualArr = NewCustomList1.WorkingArray;

            if (expectedArr.SequenceEqual(actualArr))
            {
                actual = true;
            }
            else
            {
                actual = false;
            }

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        //------------------------------------Quick Sort Method---------------------------------
        [TestMethod]
        public void HaveArrayOfInts_UseQuickSortToSort_ReturnSortArray()
        {
            CustomList<int> NewCustomList1 = new CustomList<int>();

            bool expected = true;
            bool actual;

            int[] expectedArr = { 1, 2, 3, 4, 5, 6, 7, 0 };
            int[] actualArr;

            //act - act on the method under test  
            for (int i =7; i > 0; i--)
            {
                NewCustomList1.Add(i);
            }
            NewCustomList1 = NewCustomList1.Sort(NewCustomList1.WorkingArray);
            actualArr = NewCustomList1.WorkingArray;

            if (expectedArr.SequenceEqual(actualArr))
            {
                actual = true;
            }
            else
            {
                actual = false;
            }

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
    }
}