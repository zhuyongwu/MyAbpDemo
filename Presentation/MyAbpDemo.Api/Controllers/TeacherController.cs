﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyAbpDemo.Application;
using Castle.Core.Logging;
using Microsoft.AspNetCore.Http;
using MyAbpDemo.ApplicationDto;

//1: 导入日志的命名空间，Castle.Core.Logging


namespace MyAbpDemo.Api.Controllers
{
 
    public class TeacherController : ApiControllerBase
    {
        private readonly ITeacherAppService _teacherAppService;

        public TeacherController(ITeacherAppService teacherAppService)
        {
            _teacherAppService = teacherAppService;
        }

        /// <summary>
        /// 获取老师信息
        /// </summary>
        /// <returns></returns>
        /// <response code="200">成功</response>
        /// <response code="400">失败返回Result对象</response>  
        [HttpGet("teachers")]
        [ProducesResponseType(typeof(List<GetTeacherListOutput>),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetTeacher()
        {
            //Logger.Info("记录日志: "+DateTime.Now );
            var list =await  _teacherAppService.GetTeacherList();
            return   Ok(list);
        }
    }
}