using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    class StackElement : IEnumerable<CustomerRecord>
    {
        private List<CustomerRecord> list = new List<CustomerRecord>();

        public void Push(CustomerRecord record)
        {
            list.Add(record);
        }

        public void Pop()
        {
            int rows = list.Count;
            if (rows > 0)
            {
                list.RemoveAt(rows -1);//last entry
            }
        }

        public string Peek()
        {
            if (list.Count > 0)
            {

                return list[0].ToString();
            }
            else return null;
        }

        public int Count ()
        {
            return list.Count;
        }


        //IEnumerable<CustomerRecord> List = list.GetEnumerator();
        //public IEnumerable<CustomerRecord> GetEnumerator()
        //{
        //    List<CustomerRecord> flip = list.Reverse;
        //}
        //public IEnumerable GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<CustomerRecord> IEnumerable<CustomerRecord>.GetEnumerator()
        {
            //IEnumerator<CustomerRecord> ListEnum;

            //foreach (CustomerRecord entry in list)
            //{
            //    ListEnum.A entry;
            //}


            //return ListEnum;
            return ((IEnumerable<CustomerRecord>)list).GetEnumerator();
        }
    }
}
