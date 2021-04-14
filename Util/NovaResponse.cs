using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKVC.Util
{
    public class NovaResponse
    {
        public string status { get; set; }
        public string message { get; set; }
        public IList<Object> data { get; set; }


        public NovaResponse(string status, string message, IList<Object> data)
        {
            this.status = status;
            this.message = message;
            this.data = data;
        }

        public NovaResponse(string status, string message)
        {
            this.status = status;
            this.message = message;
        }

        public static NovaResponse SUCCESS(IList<Object> data)
        {
            return new NovaResponse("200", "SUCCESS", data);
        }

        public static NovaResponse SUCCESS(Object data)
        {
            List<Object> returnData = new List<Object>();
            returnData.Add(data);
            return new NovaResponse("200", "SUCCESS", returnData);
        }
        public static NovaResponse SUCCESS()
        {
            return new NovaResponse("200", "SUCCESS");
        }
        //trả về SUCCESSNOTBIDDING trong hoàn tiền đặt cọc
        //public static Response SUCCESSNOTBIDDING(Object data)
        //{
        //    List<Object> returnData = new List<Object>();
        //    returnData.Add(data);
        //    return new Response("205", "SUCCESSNOTBIDDING", returnData);
        //}
        public static NovaResponse SUCCESSNOTBIDDING(IList<Object> data)
        {
            return new NovaResponse("205", "SUCCESSNOTBIDDING", data);
        }
        //trả về SUCCESSHAVEBIDDING trong hoàn tiền đặt cọc
        //public static Response SUCCESSHAVEBIDDING(Object data)
        //{
        //    List<Object> returnData = new List<Object>();
        //    returnData.Add(data);
        //    return new Response("206", "SUCCESSHAVEBIDDING", returnData);
        //}
        public static NovaResponse SUCCESSHAVEBIDDING(IList<Object> data)
        {
            return new NovaResponse("206", "SUCCESSHAVEBIDDING", data);
        }

        public static NovaResponse CREATED(Object data)
        {
            List<Object> returnData = new List<Object>();
            returnData.Add(data);
            return new NovaResponse("201", "CREATED", returnData);
        }

        public static NovaResponse Faild()
        {
            return new NovaResponse("099", "FAILD");
        }

        public static NovaResponse EmailExist(Object data)
        {
            List<Object> returnData = new List<Object>();
            returnData.Add(data);
            return new NovaResponse("202", "EMAILEXIST", returnData);
        }

        public static NovaResponse UsernameExist(Object data)
        {
            List<Object> returnData = new List<Object>();
            returnData.Add(data);
            return new NovaResponse("203", "USENAMEEXIST", returnData);
        }
        public static NovaResponse BiddingRequestExist(Object data)
        {
            List<Object> returnData = new List<Object>();
            returnData.Add(data);
            return new NovaResponse("203", "BIDDINGREQUESTEXIST", returnData);
        }
        public static NovaResponse PhoneExist(Object data)
        {
            List<Object> returnData = new List<Object>();
            returnData.Add(data);
            return new NovaResponse("204", "PHONEEXIST", returnData);
        }
        public static NovaResponse ItemExist(Object data)
        {
            List<Object> returnData = new List<Object>();
            returnData.Add(data);
            return new NovaResponse("203", "ITEMEXIST", returnData);
        }
        public static NovaResponse NotFoundBiddingMax()
        {
            return new NovaResponse("999", "FAILD");
        }
        public static NovaResponse PasswordExist(Object data)
        {
            List<Object> returnData = new List<Object>();
            returnData.Add(data);
            return new NovaResponse("202", "PASSWORDEXIST", returnData);
        }
    }
}
