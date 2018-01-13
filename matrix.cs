﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;

namespace DemoOpenGLBasicsCS
{
    public class matrix
    {
        private Vector3D startvektor;
        private Matrix3D matrixstart;

        private Vector3D matrixturm;
        private Matrix3D turmzuausleger;

        private Vector3D matrixausleger;
        private Matrix3D auslegerzuseil;

        private Vector3D matrixseil;
        private Vector3D seilVector;

        private double z;
        private double x;
        private double y;

        public Vector3D Matrixausleger { get => matrixausleger; set => matrixausleger = value; }
        public Matrix3D Auslegerzuseil { get => auslegerzuseil; set => auslegerzuseil = value; }
        public Vector3D Matrixseil { get => matrixseil; set => matrixseil = value; }
        public Vector3D SeilVector { get => seilVector; set => seilVector = value; }
        public Matrix3D Turmzuausleger { get => turmzuausleger; set => turmzuausleger = value; }
        public Vector3D Matrixturm { get => matrixturm; set => matrixturm = value; }
        public Matrix3D Matrixstart { get => matrixstart; set => matrixstart = value; }
        public Vector3D Startvektor { get => startvektor; set => startvektor = value; }
        public double X { get => x; }
        public double Y { get => y; }
        public double Z { get => z; }

        public void zielpunkt()
        {
            Vector3D tempvector = Vector3D.Multiply(Startvektor, Matrixstart);
            Vector3D tempvector2 = Vector3D.Add(tempvector, Matrixturm);
            Vector3D tempvector3 = Vector3D.Multiply(tempvector2, Turmzuausleger);
            Vector3D tempvector4 = Vector3D.Add(tempvector3, Matrixausleger);
            Vector3D tempvector5 = Vector3D.Multiply(tempvector4, Auslegerzuseil);
            Vector3D tempvector6 = Vector3D.Add(tempvector5, Matrixseil);
            Vector3D resultvector = Vector3D.Add(tempvector6, SeilVector);

            x = resultvector.X;
            y = resultvector.Y;
            z = resultvector.Z;
        }
    }
}
