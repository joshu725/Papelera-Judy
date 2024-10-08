PGDMP  (    8        	        |            papelera-judy    16.4    16.4 M    >           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            ?           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            @           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            A           1262    17031    papelera-judy    DATABASE     �   CREATE DATABASE "papelera-judy" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Spanish_Mexico.1252';
    DROP DATABASE "papelera-judy";
                postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
                pg_database_owner    false            B           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                   pg_database_owner    false    4            �            1259    17040    cliente    TABLE     �   CREATE TABLE public.cliente (
    idcliente integer NOT NULL,
    nombre character varying(50),
    direccion character varying(40),
    telefono character varying(11),
    correo character varying(50)
);
    DROP TABLE public.cliente;
       public         heap    postgres    false    4            �            1259    17039    cliente_idcliente_seq    SEQUENCE     �   CREATE SEQUENCE public.cliente_idcliente_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public.cliente_idcliente_seq;
       public          postgres    false    218    4            C           0    0    cliente_idcliente_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public.cliente_idcliente_seq OWNED BY public.cliente.idcliente;
          public          postgres    false    217            �            1259    17102    compra    TABLE     �   CREATE TABLE public.compra (
    idcompra integer NOT NULL,
    idproveedor smallint,
    idempleado smallint,
    fecha date
);
    DROP TABLE public.compra;
       public         heap    postgres    false    4            �            1259    17101    compra_idcompra_seq    SEQUENCE     �   CREATE SEQUENCE public.compra_idcompra_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public.compra_idcompra_seq;
       public          postgres    false    230    4            D           0    0    compra_idcompra_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public.compra_idcompra_seq OWNED BY public.compra.idcompra;
          public          postgres    false    229            �            1259    17119    detallecompras    TABLE     �   CREATE TABLE public.detallecompras (
    iddetallecompras integer NOT NULL,
    idcompra smallint,
    idproducto smallint,
    cantidad smallint,
    preciocompra numeric(6,2)
);
 "   DROP TABLE public.detallecompras;
       public         heap    postgres    false    4            �            1259    17118 #   detallecompras_iddetallecompras_seq    SEQUENCE     �   CREATE SEQUENCE public.detallecompras_iddetallecompras_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 :   DROP SEQUENCE public.detallecompras_iddetallecompras_seq;
       public          postgres    false    4    232            E           0    0 #   detallecompras_iddetallecompras_seq    SEQUENCE OWNED BY     k   ALTER SEQUENCE public.detallecompras_iddetallecompras_seq OWNED BY public.detallecompras.iddetallecompras;
          public          postgres    false    231            �            1259    17085    detalleventas    TABLE     �   CREATE TABLE public.detalleventas (
    iddetalleventas integer NOT NULL,
    idventa smallint,
    idproducto smallint,
    cantidad smallint,
    precio numeric(6,2)
);
 !   DROP TABLE public.detalleventas;
       public         heap    postgres    false    4            �            1259    17084 !   detalleventas_iddetalleventas_seq    SEQUENCE     �   CREATE SEQUENCE public.detalleventas_iddetalleventas_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 8   DROP SEQUENCE public.detalleventas_iddetalleventas_seq;
       public          postgres    false    228    4            F           0    0 !   detalleventas_iddetalleventas_seq    SEQUENCE OWNED BY     g   ALTER SEQUENCE public.detalleventas_iddetalleventas_seq OWNED BY public.detalleventas.iddetalleventas;
          public          postgres    false    227            �            1259    17033    empleado    TABLE       CREATE TABLE public.empleado (
    idempleado integer NOT NULL,
    nombre character varying(50),
    cargo character varying(20),
    direccion character varying(40),
    telefono character varying(11),
    sexo character varying(10),
    fechanacimiento date,
    status smallint
);
    DROP TABLE public.empleado;
       public         heap    postgres    false    4            �            1259    17032    empleado_idempleado_seq    SEQUENCE     �   CREATE SEQUENCE public.empleado_idempleado_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.empleado_idempleado_seq;
       public          postgres    false    4    216            G           0    0    empleado_idempleado_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.empleado_idempleado_seq OWNED BY public.empleado.idempleado;
          public          postgres    false    215            �            1259    17061    iva    TABLE     k   CREATE TABLE public.iva (
    idiva integer NOT NULL,
    porcentaje smallint,
    fechaaplicacion date
);
    DROP TABLE public.iva;
       public         heap    postgres    false    4            �            1259    17060    iva_idiva_seq    SEQUENCE     �   CREATE SEQUENCE public.iva_idiva_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public.iva_idiva_seq;
       public          postgres    false    224    4            H           0    0    iva_idiva_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.iva_idiva_seq OWNED BY public.iva.idiva;
          public          postgres    false    223            �            1259    17047    producto    TABLE     �   CREATE TABLE public.producto (
    idproducto integer NOT NULL,
    nombre character varying(30),
    descripcion character varying(80),
    precio numeric(6,2),
    existencia smallint
);
    DROP TABLE public.producto;
       public         heap    postgres    false    4            �            1259    17046    producto_idproducto_seq    SEQUENCE     �   CREATE SEQUENCE public.producto_idproducto_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.producto_idproducto_seq;
       public          postgres    false    220    4            I           0    0    producto_idproducto_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.producto_idproducto_seq OWNED BY public.producto.idproducto;
          public          postgres    false    219            �            1259    17054 	   proveedor    TABLE     �   CREATE TABLE public.proveedor (
    idproveedor integer NOT NULL,
    nombre character varying(50),
    nombreempresa character varying(30),
    telefono character varying(11),
    correo character varying(40)
);
    DROP TABLE public.proveedor;
       public         heap    postgres    false    4            �            1259    17053    proveedor_idproveedor_seq    SEQUENCE     �   CREATE SEQUENCE public.proveedor_idproveedor_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public.proveedor_idproveedor_seq;
       public          postgres    false    222    4            J           0    0    proveedor_idproveedor_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public.proveedor_idproveedor_seq OWNED BY public.proveedor.idproveedor;
          public          postgres    false    221            �            1259    17068    venta    TABLE     }   CREATE TABLE public.venta (
    idventa integer NOT NULL,
    idcliente smallint,
    idempleado smallint,
    fecha date
);
    DROP TABLE public.venta;
       public         heap    postgres    false    4            �            1259    17067    venta_idventa_seq    SEQUENCE     �   CREATE SEQUENCE public.venta_idventa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.venta_idventa_seq;
       public          postgres    false    4    226            K           0    0    venta_idventa_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.venta_idventa_seq OWNED BY public.venta.idventa;
          public          postgres    false    225            y           2604    17043    cliente idcliente    DEFAULT     v   ALTER TABLE ONLY public.cliente ALTER COLUMN idcliente SET DEFAULT nextval('public.cliente_idcliente_seq'::regclass);
 @   ALTER TABLE public.cliente ALTER COLUMN idcliente DROP DEFAULT;
       public          postgres    false    217    218    218                       2604    17105    compra idcompra    DEFAULT     r   ALTER TABLE ONLY public.compra ALTER COLUMN idcompra SET DEFAULT nextval('public.compra_idcompra_seq'::regclass);
 >   ALTER TABLE public.compra ALTER COLUMN idcompra DROP DEFAULT;
       public          postgres    false    230    229    230            �           2604    17122    detallecompras iddetallecompras    DEFAULT     �   ALTER TABLE ONLY public.detallecompras ALTER COLUMN iddetallecompras SET DEFAULT nextval('public.detallecompras_iddetallecompras_seq'::regclass);
 N   ALTER TABLE public.detallecompras ALTER COLUMN iddetallecompras DROP DEFAULT;
       public          postgres    false    232    231    232            ~           2604    17088    detalleventas iddetalleventas    DEFAULT     �   ALTER TABLE ONLY public.detalleventas ALTER COLUMN iddetalleventas SET DEFAULT nextval('public.detalleventas_iddetalleventas_seq'::regclass);
 L   ALTER TABLE public.detalleventas ALTER COLUMN iddetalleventas DROP DEFAULT;
       public          postgres    false    227    228    228            x           2604    17036    empleado idempleado    DEFAULT     z   ALTER TABLE ONLY public.empleado ALTER COLUMN idempleado SET DEFAULT nextval('public.empleado_idempleado_seq'::regclass);
 B   ALTER TABLE public.empleado ALTER COLUMN idempleado DROP DEFAULT;
       public          postgres    false    215    216    216            |           2604    17064 	   iva idiva    DEFAULT     f   ALTER TABLE ONLY public.iva ALTER COLUMN idiva SET DEFAULT nextval('public.iva_idiva_seq'::regclass);
 8   ALTER TABLE public.iva ALTER COLUMN idiva DROP DEFAULT;
       public          postgres    false    224    223    224            z           2604    17050    producto idproducto    DEFAULT     z   ALTER TABLE ONLY public.producto ALTER COLUMN idproducto SET DEFAULT nextval('public.producto_idproducto_seq'::regclass);
 B   ALTER TABLE public.producto ALTER COLUMN idproducto DROP DEFAULT;
       public          postgres    false    220    219    220            {           2604    17057    proveedor idproveedor    DEFAULT     ~   ALTER TABLE ONLY public.proveedor ALTER COLUMN idproveedor SET DEFAULT nextval('public.proveedor_idproveedor_seq'::regclass);
 D   ALTER TABLE public.proveedor ALTER COLUMN idproveedor DROP DEFAULT;
       public          postgres    false    221    222    222            }           2604    17071    venta idventa    DEFAULT     n   ALTER TABLE ONLY public.venta ALTER COLUMN idventa SET DEFAULT nextval('public.venta_idventa_seq'::regclass);
 <   ALTER TABLE public.venta ALTER COLUMN idventa DROP DEFAULT;
       public          postgres    false    226    225    226            -          0    17040    cliente 
   TABLE DATA           Q   COPY public.cliente (idcliente, nombre, direccion, telefono, correo) FROM stdin;
    public          postgres    false    218   �X       9          0    17102    compra 
   TABLE DATA           J   COPY public.compra (idcompra, idproveedor, idempleado, fecha) FROM stdin;
    public          postgres    false    230   �Y       ;          0    17119    detallecompras 
   TABLE DATA           h   COPY public.detallecompras (iddetallecompras, idcompra, idproducto, cantidad, preciocompra) FROM stdin;
    public          postgres    false    232   �Y       7          0    17085    detalleventas 
   TABLE DATA           _   COPY public.detalleventas (iddetalleventas, idventa, idproducto, cantidad, precio) FROM stdin;
    public          postgres    false    228   Z       +          0    17033    empleado 
   TABLE DATA           q   COPY public.empleado (idempleado, nombre, cargo, direccion, telefono, sexo, fechanacimiento, status) FROM stdin;
    public          postgres    false    216   GZ       3          0    17061    iva 
   TABLE DATA           A   COPY public.iva (idiva, porcentaje, fechaaplicacion) FROM stdin;
    public          postgres    false    224   K[       /          0    17047    producto 
   TABLE DATA           W   COPY public.producto (idproducto, nombre, descripcion, precio, existencia) FROM stdin;
    public          postgres    false    220   �[       1          0    17054 	   proveedor 
   TABLE DATA           Y   COPY public.proveedor (idproveedor, nombre, nombreempresa, telefono, correo) FROM stdin;
    public          postgres    false    222   Q\       5          0    17068    venta 
   TABLE DATA           F   COPY public.venta (idventa, idcliente, idempleado, fecha) FROM stdin;
    public          postgres    false    226   7]       L           0    0    cliente_idcliente_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.cliente_idcliente_seq', 4, true);
          public          postgres    false    217            M           0    0    compra_idcompra_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.compra_idcompra_seq', 1, true);
          public          postgres    false    229            N           0    0 #   detallecompras_iddetallecompras_seq    SEQUENCE SET     Q   SELECT pg_catalog.setval('public.detallecompras_iddetallecompras_seq', 2, true);
          public          postgres    false    231            O           0    0 !   detalleventas_iddetalleventas_seq    SEQUENCE SET     O   SELECT pg_catalog.setval('public.detalleventas_iddetalleventas_seq', 2, true);
          public          postgres    false    227            P           0    0    empleado_idempleado_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.empleado_idempleado_seq', 4, true);
          public          postgres    false    215            Q           0    0    iva_idiva_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.iva_idiva_seq', 2, true);
          public          postgres    false    223            R           0    0    producto_idproducto_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.producto_idproducto_seq', 4, true);
          public          postgres    false    219            S           0    0    proveedor_idproveedor_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.proveedor_idproveedor_seq', 4, true);
          public          postgres    false    221            T           0    0    venta_idventa_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.venta_idventa_seq', 1, true);
          public          postgres    false    225            �           2606    17045    cliente cliente_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public.cliente
    ADD CONSTRAINT cliente_pkey PRIMARY KEY (idcliente);
 >   ALTER TABLE ONLY public.cliente DROP CONSTRAINT cliente_pkey;
       public            postgres    false    218            �           2606    17107    compra compra_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.compra
    ADD CONSTRAINT compra_pkey PRIMARY KEY (idcompra);
 <   ALTER TABLE ONLY public.compra DROP CONSTRAINT compra_pkey;
       public            postgres    false    230            �           2606    17124 "   detallecompras detallecompras_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public.detallecompras
    ADD CONSTRAINT detallecompras_pkey PRIMARY KEY (iddetallecompras);
 L   ALTER TABLE ONLY public.detallecompras DROP CONSTRAINT detallecompras_pkey;
       public            postgres    false    232            �           2606    17090     detalleventas detalleventas_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY public.detalleventas
    ADD CONSTRAINT detalleventas_pkey PRIMARY KEY (iddetalleventas);
 J   ALTER TABLE ONLY public.detalleventas DROP CONSTRAINT detalleventas_pkey;
       public            postgres    false    228            �           2606    17038    empleado empleado_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.empleado
    ADD CONSTRAINT empleado_pkey PRIMARY KEY (idempleado);
 @   ALTER TABLE ONLY public.empleado DROP CONSTRAINT empleado_pkey;
       public            postgres    false    216            �           2606    17066    iva iva_pkey 
   CONSTRAINT     M   ALTER TABLE ONLY public.iva
    ADD CONSTRAINT iva_pkey PRIMARY KEY (idiva);
 6   ALTER TABLE ONLY public.iva DROP CONSTRAINT iva_pkey;
       public            postgres    false    224            �           2606    17052    producto producto_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.producto
    ADD CONSTRAINT producto_pkey PRIMARY KEY (idproducto);
 @   ALTER TABLE ONLY public.producto DROP CONSTRAINT producto_pkey;
       public            postgres    false    220            �           2606    17059    proveedor proveedor_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.proveedor
    ADD CONSTRAINT proveedor_pkey PRIMARY KEY (idproveedor);
 B   ALTER TABLE ONLY public.proveedor DROP CONSTRAINT proveedor_pkey;
       public            postgres    false    222            �           2606    17073    venta venta_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.venta
    ADD CONSTRAINT venta_pkey PRIMARY KEY (idventa);
 :   ALTER TABLE ONLY public.venta DROP CONSTRAINT venta_pkey;
       public            postgres    false    226            �           2606    17074    venta fk_idcliente    FK CONSTRAINT     |   ALTER TABLE ONLY public.venta
    ADD CONSTRAINT fk_idcliente FOREIGN KEY (idcliente) REFERENCES public.cliente(idcliente);
 <   ALTER TABLE ONLY public.venta DROP CONSTRAINT fk_idcliente;
       public          postgres    false    226    4740    218            �           2606    17125    detallecompras fk_idcompra    FK CONSTRAINT     �   ALTER TABLE ONLY public.detallecompras
    ADD CONSTRAINT fk_idcompra FOREIGN KEY (idcompra) REFERENCES public.compra(idcompra);
 D   ALTER TABLE ONLY public.detallecompras DROP CONSTRAINT fk_idcompra;
       public          postgres    false    230    232    4752            �           2606    17079    venta fk_idempleado    FK CONSTRAINT     �   ALTER TABLE ONLY public.venta
    ADD CONSTRAINT fk_idempleado FOREIGN KEY (idempleado) REFERENCES public.empleado(idempleado);
 =   ALTER TABLE ONLY public.venta DROP CONSTRAINT fk_idempleado;
       public          postgres    false    216    4738    226            �           2606    17113    compra fk_idempleado    FK CONSTRAINT     �   ALTER TABLE ONLY public.compra
    ADD CONSTRAINT fk_idempleado FOREIGN KEY (idempleado) REFERENCES public.empleado(idempleado);
 >   ALTER TABLE ONLY public.compra DROP CONSTRAINT fk_idempleado;
       public          postgres    false    230    216    4738            �           2606    17096    detalleventas fk_idproducto    FK CONSTRAINT     �   ALTER TABLE ONLY public.detalleventas
    ADD CONSTRAINT fk_idproducto FOREIGN KEY (idproducto) REFERENCES public.producto(idproducto);
 E   ALTER TABLE ONLY public.detalleventas DROP CONSTRAINT fk_idproducto;
       public          postgres    false    4742    220    228            �           2606    17130    detallecompras fk_idproducto    FK CONSTRAINT     �   ALTER TABLE ONLY public.detallecompras
    ADD CONSTRAINT fk_idproducto FOREIGN KEY (idproducto) REFERENCES public.producto(idproducto);
 F   ALTER TABLE ONLY public.detallecompras DROP CONSTRAINT fk_idproducto;
       public          postgres    false    4742    232    220            �           2606    17108    compra fk_idproveedor    FK CONSTRAINT     �   ALTER TABLE ONLY public.compra
    ADD CONSTRAINT fk_idproveedor FOREIGN KEY (idproveedor) REFERENCES public.proveedor(idproveedor);
 ?   ALTER TABLE ONLY public.compra DROP CONSTRAINT fk_idproveedor;
       public          postgres    false    222    4744    230            �           2606    17091    detalleventas fk_idventa    FK CONSTRAINT     |   ALTER TABLE ONLY public.detalleventas
    ADD CONSTRAINT fk_idventa FOREIGN KEY (idventa) REFERENCES public.venta(idventa);
 B   ALTER TABLE ONLY public.detalleventas DROP CONSTRAINT fk_idventa;
       public          postgres    false    228    4748    226            -   �   x�M�1N�0E��),mo9��8���EZ�!�ă���N���� +��_��O��#%��3�9Oa�H+Bgup��پ3����Z�-\M�Y���Q�G~!�`u�ﴪ��0q^ѣ:�}	um]Ƙ�����3/(;V'J)���=��,t��IY�4���4������l�Y8�iq���$b���e��BH���)��3m�U�:x��5n���Ϻ(��a0      9      x�3�4�4�4202�5�"�=... &�V      ;   "   x�3�4B#Nc=.#0(d���qqq R��      7   #   x�3�4B#N=.# �$d���qqq V��      +   �   x�U�=N�0���9���Fc��.)�Q�+�T4��h)���P�(���E��r3~�~Z����n��|�0x:�7���$��ent!�B���j[�=N�2�!
�(��h�3#�8�_�yX>q���r?ؼF�(�ӌ╮j]2
�����JA��`�`4�H>xn�Q��S���K��H�̵3�ZWAY��j ��F���mC�F��H�z�m?R�����y�����k%4�x$>��l���V�~�e�7t�d�      3   )   x�3�44�4202�5�".#NCS�P��P�Ȓ+F��� sv�      /   �   x�]��1Ekg
�Prw� T�hLbAP�!	l�'F�����������9�cL�� �d+���#ݼ㡧	&	A�1���%I�v��Z�Ѫ���H����(��˕�����x�c���!H���NXP*��c�E�����=�)O�Љ�^�s�Q�N%X�#�������Y������T)��!W{      1   �   x�m�An�0EדS�	"�ĉ�+�,���`�͐��Ȏ#;��� �"��Z5�n��<�y�����W�j>��k��x'�Q�>���@��*/D)�%m'�|��MZ;�,`i�Ͻ�u�i�>��βs~��R岐���g�I2x�Ǟn�M1�H)r��R.&U���Μ9�z:���_dj:�8��Ɲ)��v��XV�2!�N�}�4��#M��Ueu      5      x�3�4B##]K ����� &�U     