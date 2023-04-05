# To_Do_App_Final_Project-main
 ความเป็นมาของโปรแกรม
เนื่องจากเป็นคนขี้ลืม จึงได้สร้างโปรแกรมช่วยจดรายการต่างๆ ไว้พร้อมวันที่กำหนด
เพื่อเป็นการฝึกวินัยไปในตัว

 วัตถุประสงค์ของโปรแกรม
 1.ป้องกันอาการหลงลืม
 2.อยากพัฒนาโปรแกรมฝึกวินัย

 โครงสร้างของโปรแกรม
 ```mermaid
    classDiagram
        To_Do_Form <|-- To_Do_Controller
        To_Do_Form <|-- Task_Info_Form
        To_Do_Form <|-- Task_Detail_Form
        Task_Info_Form <|-- Task
        To_Do_Controller <|-- Task
        Task : +String Title
        Task : +String Description
        Task: +DateTime DueDate
        Task: +Task()
        class Task_Info_Form{
        +_newTask
        +buttonAddInfo_Click()
        +GetTask()
        +Task_Info_Form()
        }
        class To_Do_Form{
        +controller
        +selectedTask
        +List<Task> tasks
        +buttonAdd_Click()
        +buttonDetail_Click()
        +buttonDelete_Click()
        +dataGridView1_CellClick_1()
        +getSelecetedTask()
        +openToolStripMenuItem_Click()
        +saveToolStripMenuItem_Click()
        +To_Do_Form()
        }
        class To_Do_Controller{
            +List<Task>_task
            +Addtask()
        }
        class Task_Detail_Form{
            +buttonBackDetail_Click()
            +Detail()
        }
```
 ผู้พัฒนาโปรแกรม
นายเทพฤทธิ์ อินทรประพันธ์ 653450091-4