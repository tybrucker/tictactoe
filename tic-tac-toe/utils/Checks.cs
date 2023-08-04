//namespace tic_tac_toe
//{
//    internal class Checks
//    {
//        private bool Check1()
//        {
//            if (square_tl.piece != 'N')
//            {
//                if (square_tl.piece == square_tm.piece && square_tm.piece == square_tr.piece)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }

//        private bool Check2()
//        {
//            if (square_mm.piece != 'N')
//            {
//                if (square_ml.piece == square_mm.piece && square_mm.piece == square_mr.piece)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }

//        private bool Check3()
//        {
//            if (square_br.piece != 'N')
//            {
//                if (square_br.piece == square_bm.piece && square_bm.piece == square_bl.piece)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }

//        private bool Check4()
//        {
//            if (square_tr.piece != 'N')
//            {
//                if (square_tl.piece == square_ml.piece && square_ml.piece == square_bl.piece)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }

//        private bool Check5()
//        {
//            if (square_mm.piece != 'N')
//            {
//                if (square_tm.piece == square_mm.piece && square_mm.piece == square_bm.piece)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }

//        private bool Check6()
//        {
//            if (square_br.piece != 'N')
//            {
//                if (square_br.piece == square_mr.piece && square_mr.piece == square_tr.piece)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }

//        private bool Check7()
//        {
//            if (square_mm.piece != 'N')
//            {
//                if (square_tl.piece == square_mm.piece && square_mm.piece == square_br.piece)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }

//        private bool Check8()
//        {
//            if (square_mm.piece != 'N')
//            {
//                if (square_tr.piece == square_mm.piece && square_mm.piece == square_bl.piece)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }
//    }
//}
