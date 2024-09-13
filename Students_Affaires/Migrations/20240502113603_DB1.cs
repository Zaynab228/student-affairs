using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Students_Affaires.Migrations
{
    /// <inheritdoc />
    public partial class DB1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAdmin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageDoctor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorID);
                });

            migrationBuilder.CreateTable(
                name: "Engineers",
                columns: table => new
                {
                    EngineerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageEngineer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engineers", x => x.EngineerID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Affairs",
                columns: table => new
                {
                    AffairID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AffairName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAffairl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Affairs", x => x.AffairID);
                    table.ForeignKey(
                        name: "FK_Affairs_Admins_AdminID",
                        column: x => x.AdminID,
                        principalTable: "Admins",
                        principalColumn: "AdminID");
                });

            migrationBuilder.CreateTable(
                name: "Controls",
                columns: table => new
                {
                    ControlID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageControl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Controls", x => x.ControlID);
                    table.ForeignKey(
                        name: "FK_Controls_Admins_AdminID",
                        column: x => x.AdminID,
                        principalTable: "Admins",
                        principalColumn: "AdminID");
                });

            migrationBuilder.CreateTable(
                name: "Give",
                columns: table => new
                {
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Give", x => new { x.CourseID, x.DoctorID });
                    table.ForeignKey(
                        name: "FK_Give_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Give_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiveCourse",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    EngineerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiveCourse", x => new { x.CourseID, x.EngineerID });
                    table.ForeignKey(
                        name: "FK_GiveCourse_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GiveCourse_Engineers_EngineerID",
                        column: x => x.EngineerID,
                        principalTable: "Engineers",
                        principalColumn: "EngineerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Responsible",
                columns: table => new
                {
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    EngineerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsible", x => new { x.DoctorID, x.EngineerID });
                    table.ForeignKey(
                        name: "FK_Responsible_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Responsible_Engineers_EngineerID",
                        column: x => x.EngineerID,
                        principalTable: "Engineers",
                        principalColumn: "EngineerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Register",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Register", x => new { x.CourseID, x.StudentID });
                    table.ForeignKey(
                        name: "FK_Register_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Register_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeachesStudent",
                columns: table => new
                {
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachesStudent", x => new { x.DoctorID, x.StudentID });
                    table.ForeignKey(
                        name: "FK_TeachesStudent_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeachesStudent_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeachesStudent2",
                columns: table => new
                {
                    EngineerID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachesStudent2", x => new { x.StudentID, x.EngineerID });
                    table.ForeignKey(
                        name: "FK_TeachesStudent2_Engineers_EngineerID",
                        column: x => x.EngineerID,
                        principalTable: "Engineers",
                        principalColumn: "EngineerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeachesStudent2_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreCourse",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    ControlID = table.Column<int>(type: "int", nullable: false),
                    AffairID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreCourse", x => new { x.ControlID, x.CourseID, x.AffairID });
                    table.ForeignKey(
                        name: "FK_StoreCourse_Affairs_AffairID",
                        column: x => x.AffairID,
                        principalTable: "Affairs",
                        principalColumn: "AffairID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreCourse_Controls_ControlID",
                        column: x => x.ControlID,
                        principalTable: "Controls",
                        principalColumn: "ControlID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreCourse_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreDoctor",
                columns: table => new
                {
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    ControlID = table.Column<int>(type: "int", nullable: false),
                    AffairID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreDoctor", x => new { x.DoctorID, x.ControlID, x.AffairID });
                    table.ForeignKey(
                        name: "FK_StoreDoctor_Affairs_AffairID",
                        column: x => x.AffairID,
                        principalTable: "Affairs",
                        principalColumn: "AffairID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreDoctor_Controls_ControlID",
                        column: x => x.ControlID,
                        principalTable: "Controls",
                        principalColumn: "ControlID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreDoctor_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreEngineer",
                columns: table => new
                {
                    EngineerID = table.Column<int>(type: "int", nullable: false),
                    ControlID = table.Column<int>(type: "int", nullable: false),
                    AffairID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreEngineer", x => new { x.ControlID, x.EngineerID, x.AffairID });
                    table.ForeignKey(
                        name: "FK_StoreEngineer_Affairs_AffairID",
                        column: x => x.AffairID,
                        principalTable: "Affairs",
                        principalColumn: "AffairID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreEngineer_Controls_ControlID",
                        column: x => x.ControlID,
                        principalTable: "Controls",
                        principalColumn: "ControlID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreEngineer_Engineers_EngineerID",
                        column: x => x.EngineerID,
                        principalTable: "Engineers",
                        principalColumn: "EngineerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreStudent",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    ControlID = table.Column<int>(type: "int", nullable: false),
                    AffairID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreStudent", x => new { x.ControlID, x.StudentID, x.AffairID });
                    table.ForeignKey(
                        name: "FK_StoreStudent_Affairs_AffairID",
                        column: x => x.AffairID,
                        principalTable: "Affairs",
                        principalColumn: "AffairID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreStudent_Controls_ControlID",
                        column: x => x.ControlID,
                        principalTable: "Controls",
                        principalColumn: "ControlID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreStudent_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Affairs_AdminID",
                table: "Affairs",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Controls_AdminID",
                table: "Controls",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Give_DoctorID",
                table: "Give",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_GiveCourse_EngineerID",
                table: "GiveCourse",
                column: "EngineerID");

            migrationBuilder.CreateIndex(
                name: "IX_Register_StudentID",
                table: "Register",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Responsible_EngineerID",
                table: "Responsible",
                column: "EngineerID");

            migrationBuilder.CreateIndex(
                name: "IX_StoreCourse_AffairID",
                table: "StoreCourse",
                column: "AffairID");

            migrationBuilder.CreateIndex(
                name: "IX_StoreCourse_CourseID",
                table: "StoreCourse",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_StoreDoctor_AffairID",
                table: "StoreDoctor",
                column: "AffairID");

            migrationBuilder.CreateIndex(
                name: "IX_StoreDoctor_ControlID",
                table: "StoreDoctor",
                column: "ControlID");

            migrationBuilder.CreateIndex(
                name: "IX_StoreEngineer_AffairID",
                table: "StoreEngineer",
                column: "AffairID");

            migrationBuilder.CreateIndex(
                name: "IX_StoreEngineer_EngineerID",
                table: "StoreEngineer",
                column: "EngineerID");

            migrationBuilder.CreateIndex(
                name: "IX_StoreStudent_AffairID",
                table: "StoreStudent",
                column: "AffairID");

            migrationBuilder.CreateIndex(
                name: "IX_StoreStudent_StudentID",
                table: "StoreStudent",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_TeachesStudent_StudentID",
                table: "TeachesStudent",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_TeachesStudent2_EngineerID",
                table: "TeachesStudent2",
                column: "EngineerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Give");

            migrationBuilder.DropTable(
                name: "GiveCourse");

            migrationBuilder.DropTable(
                name: "Register");

            migrationBuilder.DropTable(
                name: "Responsible");

            migrationBuilder.DropTable(
                name: "StoreCourse");

            migrationBuilder.DropTable(
                name: "StoreDoctor");

            migrationBuilder.DropTable(
                name: "StoreEngineer");

            migrationBuilder.DropTable(
                name: "StoreStudent");

            migrationBuilder.DropTable(
                name: "TeachesStudent");

            migrationBuilder.DropTable(
                name: "TeachesStudent2");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Affairs");

            migrationBuilder.DropTable(
                name: "Controls");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Engineers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
