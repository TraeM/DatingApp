using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

using DatingApp.Data;

namespace DatingApp.Fakes
{
    public static class FakesGenerator
    {
        public static string GenerateFirstName()
        {
            throw new NotImplementedException();
        }

        public static string GenerateLastName()
        {
            throw new NotImplementedException();
        }

        public static string GenerateAge()
        {
            throw new NotImplementedException();
        }

        public static string GenerateGender()
        {
            throw new NotImplementedException();
        }

        public static string GenerateBio()
        {
            throw new NotImplementedException();
        }

        public static string GenerateIntrest()
        {
            throw new NotImplementedException();
        }

        public static string GenerateLocation()
        {
            throw new NotImplementedException();
        }
    }

    public class DataSetGenerator
    {
        public event EventHandler<DataSetGeneratorEventArgs> DataSetSchemaComplete;
        public event EventHandler<DataSetGeneratorEventArgs> DataSetGenerationComplete;

        public void GenerateDataSetSchema()
        {
            typeof(CardContiner).GetRuntimeProperties()
        }

        public void GenerateDataSet()
        {
            
        }

        private void OnDataSetSchemaComplete(DataSetGeneratorEventArgs e)
        {
            DataSetSchemaComplete?.Invoke(this,e);
        }

        private void OnDataSetGenerationComplete(DataSetGeneratorEventArgs e)
        {
            DataSetGenerationComplete?.Invoke(this,e);
        }
    }

    public class DataSetGeneratorEventArgs : EventArgs
    {
        public string Xml { get; }
        public DataSetGeneratorEventArgs(string xml)
        {
            Xml = xml;
        }
    }

    public static class ReflectionExtensions
    {
        public static IEnumerable<Type> WInheirtsFrom<T>(this Type type, T parentType) where T : class
        {
            type.GetRuntimeProperties()
        }

        public static IEnumerable<Type> <T>(this Type type, T parentType) where T : class
        {
            type.GetRuntimeProperties()
        }
    }
}