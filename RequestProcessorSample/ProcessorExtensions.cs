using System;
using System.Collections.Generic;
using System.Text;

namespace RequestProcessorSample
{

    public static class ProcessorExtensions
    {
        public static void SetResponceTo10CharsOfInput(this InputProcessor processor)
        {
            processor.Processors.Add(inputModel =>
            {

                if (inputModel.Input.Length > 10)
                {
                    inputModel.Response = inputModel.Input.Substring(0, 10);
                }
            });
        }

        public static void PreventEvenNumbers(this InputProcessor processor)
        {
            processor.Processors.Add(inputModel =>
            {
                int a;
                if (int.TryParse(inputModel.Input, out a))
                {
                    if (a % 2 == 0)
                    {
                        inputModel.Response = "Even number not allowed";

                        processor.WriteResponse(inputModel);

                    }
                }
            });
        }

        public static void PreventSLetter(this InputProcessor processor)
        {
            processor.Processors.Add(inputModel =>
            {
                if (inputModel.Input.Contains('s'))
                {
                    inputModel.Response = "Letter s is not allowed blet";

                    processor.WriteResponse(inputModel);

                }
            });
        }
    }

}

