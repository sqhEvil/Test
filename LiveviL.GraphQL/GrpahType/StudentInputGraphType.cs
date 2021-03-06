﻿using GraphQL.Types;
using LiveviL.GraphQL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveviL.GraphQL.GrpahType
{
    public class StudentInputGraphType:InputObjectGraphType<Student>
    {
        public StudentInputGraphType()
        {
            Description = "学生信息输入类型";
            Field(x => x.name).Description("姓名");
            Field(x => x.score).Description("分数");
        }
    }
}
