﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlainLogic.ViscaController.Visca.Responses
{
    public sealed class Acknowledgement : ViscaResponse
    {
        public Acknowledgement() : base( ResponseTypes.Acknowledgement ) { }
    }
}
