namespace QuanLyHocSinhLINQ
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "Anạohfjnajs", Age = 16 },
                new Student { Id = 2, Name = "Bô", Age = 18 },
                new Student { Id = 3, Name = "Ank", Age = 15 },
                new Student { Id = 4, Name = "Chichi", Age = 19 },
                new Student { Id = 5, Name = "Dưts", Age = 14 }
            };

            Console.WriteLine("a. Danh sách toàn bộ học sinh:");
            students.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();

            Console.WriteLine("b. Học sinh có tuổi từ 15 đến 18:");
            var tuoi15_18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var s in tuoi15_18)
                Console.WriteLine(s);
            Console.WriteLine();

            Console.WriteLine("c. Học sinh có tên bắt đầu bằng 'A':");
            var tenA = students.Where(s => s.Name.StartsWith("A"));
            foreach (var s in tenA)
                Console.WriteLine(s);
            Console.WriteLine();

            Console.WriteLine("d. Tổng tuổi của tất cả học sinh:");
            int tongTuoi = students.Sum(s => s.Age);
            Console.WriteLine("Tổng tuổi = " + tongTuoi);
            Console.WriteLine();

            Console.WriteLine("e. Học sinh có tuổi lớn nhất:");
            int tuoiLonNhat = students.Max(s => s.Age);
            var hsLonNhat = students.Where(s => s.Age == tuoiLonNhat);
            foreach (var s in hsLonNhat)
                Console.WriteLine(s);
            Console.WriteLine();

            Console.WriteLine("f. Danh sách học sinh theo tuổi tăng dần:");
            var sapXep = students.OrderBy(s => s.Age);
            foreach (var s in sapXep)
                Console.WriteLine(s);
        }
    }
}
