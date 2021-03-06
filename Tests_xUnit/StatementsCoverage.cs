﻿using TriangleSample;
using Xunit;

namespace TestProject1
{
    public class StatementsCoverage
    {
        [Fact]
        public void test1()
        {
            int[] testArr = {3, 4, 5};
            Triangle testTr = new Triangle();
            Assert.Equal("Разносторонний", testTr.TypeOfTriangle(testArr));
        }

        [Fact]
        public void test2()
        {
            int[] testArr = {2, 4, 4};
            Triangle testTr = new Triangle();
            Assert.Equal("Равнобедренный", testTr.TypeOfTriangle(testArr));
        }

        [Fact]
        public void test3()
        {
            int[] testArr = {3, 3, 3};
            Triangle testTr = new Triangle();
            Assert.Equal("Равносторонний", testTr.TypeOfTriangle(testArr));
        }

        [Fact]
        public void vktest4()
        {
            int[] testArr = {1, -1, 1};
            Triangle testTr = new Triangle();
            Assert.Equal("Разносторонний", testTr.TypeOfTriangle(testArr)); //"Что-то пошло не так");
        }

        [Fact]
        public void test5()
        {
            int[] testArr = {2, 1, 1};
            Triangle testTr = new Triangle();
            Assert.Equal(testTr.TypeOfTriangle(testArr), "Треугольник не существует"); //, "Что-то пошло не так");
        }
    }
}