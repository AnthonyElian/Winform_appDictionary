//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace WinformDictionary_Test1
//{
//    public class Tree
//    {
//        // Tao node
//        public AVLNODE CreateNode(Word x)
//        {
//            AVLNODE pNode = new AVLNODE();
//            if (pNode == null)
//            {
//                return null;
//            }
//            else
//            {
//                pNode.Key = x;
//                pNode.pLeft = null;
//                pNode.pRight = null;
//                pNode.bal = 0;
//                return pNode;
//            }
//        }

//        // xoay phai
//        public void RightRotate(ref AVLNODE P)
//        {
//            AVLNODE Q;
//            Q = P.pLeft;
//            P.pLeft = Q.pRight;
//            Q.pRight = P;
//            P = Q;
//        }

//        // xoay trai
//        public void LeftRotate(ref AVLNODE P)
//        {
//            AVLNODE Q;
//            Q = P.pRight;
//            P.pRight = Q.pLeft;
//            Q.pLeft = P;
//            P = Q;
//        }

//        // mat can bang trai
//        public void LeftBalance(ref AVLNODE p)
//        {
//            switch(p.pLeft.bal)
//            {
//                case 1:
//                    {
//                        this.RightRotate(ref p);
//                        p.bal = 0;
//                        p.pRight.bal = 0;
//                        break;
//                    }
//                case 2:
//                    {
//                        this.LeftRotate(ref p.pLeft);
//                        this.RightRotate(ref p);
//                        switch(p.bal)
//                        {
//                            case 0:
//                                {
//                                    p.pLeft.bal = 0;
//                                    p.pRight.bal = 0;
//                                    break;
//                                }
//                            case 1:
//                                {
//                                    p.pLeft.bal = 0;
//                                    p.pRight.bal = 2;
//                                    break;
//                                }
//                            case 2:
//                                {
//                                    p.pLeft.bal = 1;
//                                    p.pRight.bal = 0;
//                                    break;
//                                }
//                        }
//                        p.bal = 0;
//                        break;
//                    }
//            }
//        }

//        public void RightBalance(ref AVLNODE p)
//        {
//            switch(p.pRight.bal)
//            {
//                case 1:
//                    {
//                        this.RightBalance(ref p.pRight);
//                        this.LeftRotate(ref p);
//                        switch(p.bal)
//                        {
//                            case 0:
//                                {
//                                    p.pLeft.bal = 0;
//                                    p.pRight.bal = 0;
//                                    break;
//                                }
//                            case 1:
//                                {
//                                    p.pLeft.bal = 1;
//                                    p.pRight.bal = 0;
//                                    break;
//                                }
//                            case 2:
//                                {
//                                    p.pLeft.bal = 0;
//                                    p.pRight.bal = 2;
//                                    break;
//                                }
//                        }
//                        p.bal = 0;
//                        break;
//                    }
//                case 2:
//                    {
//                        this.LeftRotate(ref p);
//                        p.bal = 0;
//                        p.pLeft.bal = 0;
//                        break;
//                    }
//            }
//        }
     
//        // chen node
//        public int InsertNode(ref AVLNODE tree, Word x)
//        {
//            int res;
//            if (tree == null)
//            {
//                tree = this.CreateNode(x);
//                if (tree == null)
//                {
//                    return -1;
//                }
//                else
//                {
//                    return 2;
//                }
//            }
//            else
//            {
//                if (tree.Key.STu.Length > x.STu.Length)
//                {
//                    return 0;
//                }
//                else
//                {
//                    if (tree.Key.STu.Length > x.STu.Length)
//                    {
//                        res = this.InsertNode(ref tree.pLeft, x);
//                        if (res < 2)
//                        {
//                            return res;
//                        }
//                        else
//                        {
//                            switch (tree.bal)
//                            {
//                                case 0:
//                                    {
//                                        tree.bal = 1;
//                                        return 2;
//                                    }
//                                case 1:
//                                    {
//                                        this.LeftBalance(ref tree);
//                                        return 1;
//                                    }
//                                case 2:
//                                    {
//                                        tree.bal = 0;
//                                        return 1;
//                                    }
//                            }
//                        }
//                    }
//                    else
//                    {
//                        res = this.InsertNode(ref tree.pRight, x);
//                        if (res < 2)
//                        {
//                            return res;
//                        }
//                        else
//                        {
//                            switch (tree.bal)
//                            {
//                                case 0:
//                                    {
//                                        tree.bal = 2;
//                                        return 2;
//                                    }
//                                case 1:
//                                    {
//                                        tree.bal = 0;
//                                        return 1;
//                                    }
//                                case 2:
//                                    {
//                                        this.RightBalance(ref tree);
//                                        return 1;
//                                    }
//                            }
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
