//
// System.Security.Cryptography.X509Certificates.X509Extension
//
// Author:
//	Sebastien Pouliot  <sebastien@ximian.com>
//	Tim Coleman (tim@timcoleman.com)
//
// (C) 2003 Motus Technologies Inc. (http://www.motus.com)
// Copyright (C) Tim Coleman, 2004
// Copyright (C) 2004 Novell Inc. (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

#if NET_2_0

using System;

namespace System.Security.Cryptography.X509Certificates {

	public class X509Extension : AsnEncodedData {

		private bool _critical;

		// constructors

		protected X509Extension () 
		{
		}

		public X509Extension (AsnEncodedData encodedExtension, bool critical)
			: base (encodedExtension)
		{
			_critical = critical;
		}

		public X509Extension (Oid oid, byte[] rawData, bool critical)
			: base (oid, rawData)
		{
			_critical = critical;
		}

		[MonoTODO]
		public X509Extension (string oid, byte[] rawData, bool critical)
			: base (oid, rawData)
		{
			_critical = critical;
		}

		// properties

		public bool Critical {
			get { return _critical; }
		}

		// methods

		[MonoTODO ("decode with Mono.Security")]
		public override void CopyFrom (AsnEncodedData asnEncodedData) 
		{
			if (asnEncodedData == null)
				throw new ArgumentNullException ("asnEncodedData");
		}
	}
}

#endif
