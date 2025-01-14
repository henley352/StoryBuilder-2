/********************************************************************************
 *   This file is part of NRtfTree Library.
 *
 *   NRtfTree Library is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU Lesser General Public License as published by
 *   the Free Software Foundation; either version 3 of the License, or
 *   (at your option) any later version.
 *
 *   NRtfTree Library is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU Lesser General Public License for more details.
 *
 *   You should have received a copy of the GNU Lesser General Public License
 *   along with this program. If not, see <http://www.gnu.org/licenses/>.
 ********************************************************************************/

/********************************************************************************
 * Library:		NRtfTree
 * Version:     v0.3.0
 * Date:		02/09/2007
 * Copyright:   2007 Salvador Gomez
 * E-mail:      sgoliver.net@gmail.com
 * Home Page:	http://www.sgoliver.net
 * SF Project:	http://nrtftree.sourceforge.net
 *				http://sourceforge.net/projects/nrtftree
 * Class:		RtfTokenType
 * Description:	Tipos de token de un �rbol de documento RTF.
 * ******************************************************************************/

namespace NRtfTree
{
    namespace Core
    {
        /// <summary>
        /// Tipos de token de un �rbol de documento RTF.
        /// </summary>
        public enum RtfTokenType
        {
            /// <summary>
            /// Indica que el token s�lo se ha inicializado.
            /// </summary>
            None = 0,
            /// <summary>
            /// Palabra clave sin par�metro.
            /// </summary>
            Keyword = 1,
            /// <summary>
            /// S�mbolo de Control sin par�metro.
            /// </summary>
            Control = 2,
            /// <summary>
            /// Texto del documento.
            /// </summary>
            Text = 3,
            /// <summary>
            /// Marca de fin de fichero.
            /// </summary>
            Eof = 4,
            /// <summary>
            ///	Inicio de grupo: '{'
            /// </summary>
            GroupStart = 5,
            /// <summary>
            /// Fin de grupo: '}'
            /// </summary>
            GroupEnd = 6
        }
    }
}
