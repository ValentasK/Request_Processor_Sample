using System;
using System.Collections.Generic;
using System.Text;

namespace RequestProcessorSample
{
    public class InputProcessor
    {
        public delegate void ProcessorDelegate(InputModel inputModel);
        public List<ProcessorDelegate> Processors { get; set; } = new List<ProcessorDelegate>();
        public bool Processing { get; set; }

        public void Process()
        {
            while (true)
            {
                Processing = true;
                Console.WriteLine("Waiting for input");
                var a = Console.ReadLine();
                InputModel inputModel = new InputModel()
                {
                    Input = a,
                    Response = "OK"
                };

                // processing happens here 

                foreach (ProcessorDelegate processor in Processors)
                {
                    if (this.Processing)
                    {
                        processor(inputModel);
                    }
                    else
                    {
                        break;
                    }
                }

                //
                if (Processing)
                {
                    WriteResponse(inputModel);
                }
            }
        }

        public void WriteResponse(InputModel inputModel)
        {
            this.Processing = false;
            Console.WriteLine(inputModel.Response);
        }
    }
}
