using System;
using System.Collections.Generic;
using System.Text;
using Arrays;
using Common.Interface;
using Common.Model;

namespace TaskRunner.Model
{
    public static class TaskHelper
    {
        public static ITask GetTask(ChapterType type)
        {
            switch (type)
            {
                case ChapterType.Arrays_01:
                    return new ArraysTask();
                default:
                    Console.WriteLine("查無資料");
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// 字串轉換 Enum
        /// </summary>
        public static T ToEnum<T>(this string enumAsString)
        {
            return (T)Enum.Parse(typeof(T), enumAsString, true);
        }
    }
}
