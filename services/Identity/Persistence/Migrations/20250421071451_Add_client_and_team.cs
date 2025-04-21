using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_client_and_team : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0058a4c5-fa63-f163-1074-5a56e68d92e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0092bb68-29ba-a095-2f44-758496282394"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01750712-d4ee-db14-6bc6-2fce79cc8bdb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("067e8687-b733-ebae-5ed1-1df2a6a68416"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06b0a0d1-4081-ca08-c383-3f7cd1be02e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07392842-2793-6bde-56f9-03654111fe7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07639d99-f179-d208-6bb4-e393882661ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07bee05f-1393-d877-0572-7e9ab4fc1bf1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07d76451-0506-03db-05c6-458330a6cfc7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0bd67f61-55e6-6855-6a82-1e87d025ad8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c3cdf89-7ab6-7093-d4f8-c08fc63aac08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c48eb8b-e729-337e-86ac-7de68f91f30b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d565335-64b6-8607-67c4-8f189a8efab5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d704adc-7deb-24bc-0d98-bfd1e72201fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f494083-52e4-b03c-edb5-8e331bae54c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("104ad276-b46c-a98f-aa2b-50e3d1a573e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("105644a7-3c5b-734c-8816-a5f7475a0c49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10827083-4d9a-82e0-1b6a-c0d0ccfdba9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13496b76-4138-1223-583b-c42f04fae301"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("165cc49f-2eb5-1090-41ae-58318ec217e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("165e0b76-93ed-a61a-0709-e6173f8f7b69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16a83265-6f9b-3dd3-a63b-dc1d67c9e0ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16bf3988-3f7b-3fda-a6c1-cf93c4dd93d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("172f4c3f-ef46-e342-c4fe-bc71992dbd69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17577b7b-af78-91d5-697a-789bf0506fc2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("180a41a7-9276-d62f-acbc-41757f2f76e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("197439f4-2ef6-28c6-858d-3a9553adc808"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d0a58e9-9c16-e349-f273-db81440d2d59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d48c345-d2cd-5023-39f5-9be3c0298ab2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("204a67ac-9362-7e51-3ebf-88678e707588"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2061ccb0-3e4c-bc15-14b6-2f81ffe1e665"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20866f32-9e62-296f-f498-5c15cb314fb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20b72de6-5ab6-af91-93fe-296e37f6e539"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2210097c-9631-805f-0f49-a0ef1191dae7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2240f80c-fe6f-9ae3-a16f-2c2be4035ba8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2573aab7-d4ae-2632-e632-87b47a9d79f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29525f10-2599-24d8-66c3-5c33c0256195"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29dd5889-bbb8-223b-c1b6-694638d5da36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a30649c-808c-0ae3-341f-9f4f1397c0b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bff04f7-8f56-3661-69d8-3402a5952b9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ceefe3b-063b-9189-0bcc-da39698c66a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2efe0dbb-08d3-2e7c-c277-d6b267a146ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f46e850-9242-0ced-7c1b-5b83aeea87da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("304e6d7a-7b29-cd27-8a53-687bd53aec00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32e5a87b-56d9-1df9-9a1d-1994196d0ff3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("338528d3-9af4-c671-de36-91b1eb205f47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3485d116-293b-23c8-bf83-763bc61539de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("367b96c2-b6d2-f574-4a87-855d27f678da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("376ca99a-712c-032d-643d-9c3561b2faa0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38eb94ec-4cb2-926e-e2c3-9a590ba1a5d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a1ce4a8-a49a-c16a-7b34-c9f6fe7f7d4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e5a9f75-56bf-e357-cb52-67d4e9ee12d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40089bf2-16c3-56a2-a5f7-df4216bc74fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("403700b3-8af5-87d2-032b-38846c3ddf2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40e8226d-cc00-e122-f776-ad5678902be5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40f349d9-54ae-6df6-9a5f-b10366f176ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42240cbc-34b4-6c50-b779-1d3d40230273"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4331a6f8-2879-1ed7-dd37-72d795140a70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46f8f28c-9d4f-5dd3-5605-6f1c2de7d8a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("47d11ea7-8197-cd61-ad4c-701091dd62d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48121adb-7568-a931-0c81-a9e1f40283d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("499615e1-f7c6-c110-eb41-ebb044c412d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a4638a4-10e4-f7eb-ba5f-0837cc75bf40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4fac5e66-1450-43f7-b94a-7bb9aa729115"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("520d8394-7813-a31d-6762-f3a3b65801f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("565edeb1-061a-e964-dbb2-dc60bed4adf6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5775dc78-8902-7878-87c1-f3e33fa3fe93"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("585c493d-4335-6b3c-e1ed-5744d3de93d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59c723ef-4006-d85b-b391-4f5e5b8582af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a2a9876-2a2d-2642-f974-bbde29357df7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a8b8d55-b22c-8e80-162a-626c2475a0c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b47a1cf-2acd-0d20-758b-62e11c941b28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bc50560-7be1-33ac-4d2a-63b4f7501bb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bd45ad1-30bc-2eeb-107d-52650706c3d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c52b8de-f4ea-e7e5-702e-f0f1d195d77d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d15e115-3b81-6dec-675c-e0c61658d76e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5db326b3-da43-130a-708b-642ae146287c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("665f17a6-7963-dd61-4e38-55c593ef0f6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a403057-4bad-b27e-582e-46d540bdd2ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a6fdb59-5712-8cdb-3660-d7738e68ed65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6bbc9805-8314-0b7b-7538-7b06bef52361"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6edc796f-0812-fb59-6353-734b10c183c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f6320be-0061-6073-25e2-835a022927ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7166cc5e-f488-0394-22b2-8e28aaedea22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("716bb3ae-1877-dfb7-8b55-fcd54a9baa7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a565f3-4d46-5c30-2286-dfefc576a688"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7387dbb4-37e8-39c4-0a97-f45d593e9b08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7469ea0a-a41b-ba47-33f0-9cd9abc2eec1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75573e0f-66fc-301a-3f78-040b11078f6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76202017-9833-b87b-50b6-0d688bde4a6b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("765e58fd-d7d2-cede-12a4-309dcaa25bcc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77eb78e0-3f3c-52ed-3afe-e9b9e156f729"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7890533b-99d5-3dc1-2d9b-b56ebd0fbfb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7964d853-6bab-4f45-c068-a64b9de6d1cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b47f4ce-e98a-204b-d71b-3c1aa97a5434"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c5adb77-134e-09c0-14a6-cfdd68072658"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c660504-9295-3c2f-9b20-bec9c4a8ce38"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d0efd96-d147-7ef0-17d5-03cdcdc2738f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f64f29f-40f0-d75c-970f-6e32b43b6fd9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8016d4d1-b242-bc20-4547-084abd8ccdec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84e3a52b-395c-c898-2e55-f7d9fe0033a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8672d49a-4ea3-4e7a-429e-120bc35897c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("873d728b-cbbf-74d2-dd54-995edd61353b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("874b0257-8784-5bfa-e304-0760a65de71a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a32f953-b106-8853-143e-fa9cda00db61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b0b1cf3-4974-08b8-1083-f4083ccfb70f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ba4d549-7b38-03ed-b063-c3333c9df51d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ca871ba-dcf3-171d-8d61-62acb5b5bc21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8dda0845-b78d-e7fe-69c9-85dfc0e43150"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91c8655a-3430-02fd-6646-1f59aaf5289f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92db33b6-61bf-6ca3-dc30-aad648d33795"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92e6857f-6c0c-5fc5-3684-403128d6c266"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9301b844-ecde-864f-abde-eb9e4d845807"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("937b7d8f-acba-684d-bd3c-2d5596c27c04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("948c315b-0f72-a0ba-cb59-2a602ad4b975"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95153d21-9ea2-c0cb-a6a8-3bafe6068cd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9589c16a-9afc-761a-de49-155a3e92c1d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("968bd376-79bc-1120-ff3e-b4d27477dda7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a824079-4a18-d662-0a28-e844da7e051b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a8ffcdc-ec64-6948-2bb3-705470cb8a1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b2f20ee-3513-bab5-b6d5-c8c455d37f83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b36dd89-89fc-541c-837e-435ae8a5f64e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9eb45a6e-019a-278f-01f6-d93a212c258d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ec01e5e-9851-c366-d519-b4ddf15c160f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a02fada4-f38a-c7fe-b1b6-acc30fda295e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a11a8931-36f9-92a2-7271-4af2ee5dbe3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a12cd393-04b0-186a-afe9-dbf68d8f2254"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a13d7d5d-8ee1-271c-425e-b0512602d13d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a20d9352-650f-6908-0019-371e2edbaae3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3582d66-ea36-9d38-0e3c-5644c0609f73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a614ad4e-051f-c380-b342-468db660e390"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1aa5f7d-57a4-3593-9a0f-299740c7c3d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1f36dbc-d289-bd8a-f47f-d9b1a5aa4abf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b361bc3e-aec0-56f2-6e21-52ffca3043a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b367f544-be80-59c0-4f69-29f8d52b0f7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3e952a5-3658-3146-df14-4cbdaef9f990"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b405dd95-3766-66b4-c568-96b9db3fd956"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5910a8a-853f-9a4d-e8e9-6baa51d0214d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b59b08e3-fdeb-db24-56be-b0c9ea21c09d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5d341c9-2182-fe0a-be45-1b38fa33697e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6a6b15c-7a36-a79a-87ae-7eda0ed89f78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b727c608-0aff-4a4c-d1a5-bc10e41e4d21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8312c33-f1ae-bd16-1431-3b4b516d4386"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b92f47e2-f508-0df5-8171-9adc10a4cd3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bce5aef2-aa63-281d-f148-7ad63aba47ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be11df75-fe77-41a0-5930-b5cfd1fc9d29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff2fd2a-d21d-66f5-63cd-ba1ec69cd4da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2d455f4-65bb-c019-c901-0baa8404e17a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2eba90a-53ec-9dcf-2d68-080be78057ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c55e12eb-5780-f200-9f6a-25f1c4306877"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5b217bf-5940-134b-3335-ed054e944d07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c76fbc97-8e5b-3a32-1766-d3d8a5922134"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca64fff6-b77a-a7c0-f27a-5be247be3bcf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb1517bb-e1aa-fa50-af5b-94db961366c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cbe881dd-ca70-b79d-8a9e-2f2731d4e155"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cbf4ee22-2bb5-91a3-978c-6b407c26d2e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd12f6cc-0d1c-d030-bc67-125128411865"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdfce242-2c57-99b7-d759-ef7952307894"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce365f68-67b2-ed0a-c915-0744220e81f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cee419e3-d632-8ac3-cb0f-fca9c06ebbf4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d10badc2-e6a4-8d38-f685-baa05eea99ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1446a8f-224e-9fa0-6fb7-acd5bb8bdcc1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2284369-4b06-1ebb-0f1d-1cadd1e5ef29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3473619-c598-4fde-7be8-048497a37150"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d477fa73-3653-131c-7f97-1f15ad5646a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d731c9df-5f52-7b91-6fdd-6889b3eeab43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d74b871a-a8c7-8d73-fcdb-9bd3d15ef971"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d759671d-7bdc-2d0b-e4d4-30ed96110c67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7e441cc-830f-02e5-6d13-0e26d2c96879"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d879ca1a-6f3f-0c86-76b6-af81131d66f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d95846f2-a0a3-d02c-ae24-859849f225eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9c16216-20a7-1f0b-a00a-31a0a061e571"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd5481cd-e02b-8d1e-bb11-7728cea689e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd893817-b7af-33b8-62fd-ba3da3c5833f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de608a53-4c46-e96b-8cdd-6b20175487ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de6db714-0132-3506-4eff-acb37f89fa90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dfc4fc00-48d8-54c9-945c-30a667d85988"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e138a76c-d76a-2046-5742-bc847f30f4f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e301caa6-1c51-bb74-5e43-b81273afeddb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e528dc5b-f6d3-f3d1-aacc-6702a9a151af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5bbc724-12a7-b824-d4f6-d4688e99a678"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6dd82a7-1f56-4b88-bf46-2ed1a045e920"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7f51190-4a5b-538e-af51-ae4c99c7064d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e948ea49-663a-c86b-559c-8f4e938e8887"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb99142a-7669-c073-c320-a5ef7e12327d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edf7dba1-9c8c-e1db-ff7f-9316229221d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef7e2bc2-3dd8-4927-bd40-76fb68c0aecd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7791c66-c623-a031-7e1c-7381da767bb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7ad481f-6890-a116-21e1-f61fdac34ea0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f8942f9c-1ffc-a9e8-6323-22d959b960b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb70d123-8fd1-b6c8-81df-54533aa301e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc274454-dd32-1e7a-847e-5ec74840ee73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdb0f276-be73-9a06-7710-63cc6ee38122"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe3db399-e09a-4069-f7f4-9f7483b01d35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe7f527f-9a05-6ce2-0f20-6c86d761619c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("feb8d388-d34a-c99c-3c7f-16d4dc2d5415"));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "TeamId",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsStandalone = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("087ba2d7-173c-832a-d576-5d062167b7cf"),
                columns: new[] { "Address", "Phone", "TeamId" },
                values: new object[] { "4730 Jerry Brook, North Sheridanberg, Niger", "1-605-648-5017", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1df68562-8317-b555-c1fd-fa2965514a50"),
                columns: new[] { "Address", "Phone", "TeamId" },
                values: new object[] { "71931 Weber Mission, New Seamusland, Liechtenstein", "571.579.4602", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a623381-f41d-266f-71a3-d07ac5da661e"),
                columns: new[] { "Address", "Phone", "TeamId" },
                values: new object[] { "130 Yundt Causeway, Kirlinside, Swaziland", "909.827.6076", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f07f3b97-6e81-c702-8dc2-393942fffb50"),
                columns: new[] { "Address", "Phone", "TeamId" },
                values: new object[] { "70293 Jordi Ways, Lake Roxanne, Holy See (Vatican City State)", "382.542.1597 x91122", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Email", "FirstName", "IdentityUserId", "LastName", "Phone", "Role", "TeamId" },
                values: new object[,]
                {
                    { new Guid("001cf7d5-59b0-1b3a-262c-9930a1c4a466"), "981 Adams Stream, Tremouth, Moldova", "Green87@gmail.com", "Selena", null, "Stracke", "(401) 274-1198 x9608", 3, null },
                    { new Guid("06de0b0d-fc2d-8228-a731-b7f5fbd808ab"), "96117 Balistreri Common, South Raleighshire, Latvia", "Adell.Wiza@yahoo.com", "Justine", null, "Schuppe", "360.402.7869", 1, null },
                    { new Guid("08f17907-6bd2-e3b4-9388-2661ece83c73"), "5306 Fadel Well, Kesslerside, Uzbekistan", "Domenic58@yahoo.com", "Belle", null, "Bins", "(731) 396-2727", 2, null },
                    { new Guid("0ad6624a-e828-da44-7e05-1ba105ad38ca"), "4871 Gage Drives, West Rosinaside, Bolivia", "Reta36@yahoo.com", "Nicklaus", null, "Padberg", "431.485.7579 x8820", 2, null },
                    { new Guid("0e9d38ea-563c-c044-609f-7351a1e6efd2"), "2972 Silas Route, Hagenesborough, Bahamas", "Forest13@yahoo.com", "Julianne", null, "Howe", "1-772-927-2267 x967", 1, null },
                    { new Guid("0eda7eae-9fd8-9578-6637-617213e85222"), "034 Vincenzo Courts, South Zeldashire, Kazakhstan", "Luella_Miller@hotmail.com", "Nedra", null, "Kilback", "(859) 735-1256 x70271", 2, null },
                    { new Guid("0f0d5217-46ad-ba8e-744d-d7100b2b20f2"), "859 Medhurst Pike, East Tiannahaven, Reunion", "Selina.Zemlak21@yahoo.com", "Gustave", null, "Wunsch", "1-238-346-1572 x7460", 3, null },
                    { new Guid("0f165cf1-3ee9-7aea-660d-a081dfc931d7"), "9463 McCullough Mews, Walshport, Hungary", "Jocelyn.Senger@gmail.com", "Adrianna", null, "Lowe", "642-213-7531", 3, null },
                    { new Guid("0f6d1994-ccf3-4606-f67c-ee71855a65c8"), "9925 Karlie Groves, Lake Domenico, Estonia", "Eliane.Rempel@yahoo.com", "Ruben", null, "Hintz", "(215) 232-4402 x942", 3, null },
                    { new Guid("1057629d-e8ed-9d0a-4826-0cf687b88e50"), "3944 Shields Tunnel, North June, Belize", "Xzavier.Kovacek@hotmail.com", "Ocie", null, "Gottlieb", "1-651-890-9419", 1, null },
                    { new Guid("1190ffa7-e7f5-4a5b-8e53-af51ae4c99c7"), "616 Lorena Mission, West Myahborough, Latvia", "Lucio88@yahoo.com", "Cortney", null, "Hammes", "268.212.9193 x49135", 3, null },
                    { new Guid("1430f0f6-2aef-67b8-95a7-a41fc5b93ccf"), "9021 Madelyn Plaza, North Dorian, British Indian Ocean Territory (Chagos Archipelago)", "Ramon83@gmail.com", "Alanis", null, "Kreiger", "(653) 498-1947", 3, null },
                    { new Guid("169fef91-ecb3-8a67-4e3f-4f4e859ef428"), "5087 Stokes Fields, New Lailachester, Taiwan", "Anastasia.Wunsch54@hotmail.com", "Jacinthe", null, "Johns", "705.354.0012", 1, null },
                    { new Guid("172065ed-d22d-b54d-49d7-dea6175f6663"), "1917 Keeling Mountain, New Kody, United Arab Emirates", "Jayson.Williamson17@gmail.com", "Elaina", null, "Casper", "1-514-864-2090 x194", 3, null },
                    { new Guid("17648e9d-0a67-018c-20b5-5b95b218676c"), "21756 Kara Isle, Erdmanfurt, Canada", "Eunice_Effertz@yahoo.com", "Autumn", null, "Howell", "548-868-7874 x01546", 3, null },
                    { new Guid("18412851-8065-3758-06f3-096c47be2063"), "461 Spencer Villages, North Ewald, Comoros", "Owen.Ortiz@hotmail.com", "Zoey", null, "Casper", "408-852-5792", 1, null },
                    { new Guid("18ec83b6-770c-604d-4406-d5014d6960dc"), "95413 Lang Pines, New Alize, Swaziland", "Garrison.Bashirian@yahoo.com", "Jerad", null, "Grimes", "673.305.8387 x34580", 1, null },
                    { new Guid("19678322-c9a9-3aea-d087-57f49e4d1d2c"), "55863 Wyman Terrace, East Ernestoshire, Senegal", "Brett.Fritsch17@gmail.com", "Katelin", null, "Kuhlman", "(540) 347-8948", 2, null },
                    { new Guid("1d2fb5d9-a7eb-0d1f-6ae7-d04c5276aab3"), "72972 Brendon Well, Raleighfort, Saint Kitts and Nevis", "Alysha.Howe@gmail.com", "Palma", null, "Skiles", "388.491.4274 x9249", 2, null },
                    { new Guid("1e15f6f6-736b-77fa-d453-361c137f971f"), "41469 Dustin Terrace, Port Parkertown, Kenya", "Marvin.Abbott82@yahoo.com", "Marta", null, "Swaniawski", "1-296-254-8025", 2, null },
                    { new Guid("20462d61-ea6f-9621-05c6-c912a410de6f"), "19213 Katharina Plains, Port Geoburgh, Kiribati", "Alec_Schuppe@hotmail.com", "Michale", null, "Ferry", "208.736.6557", 1, null },
                    { new Guid("20e945a0-11f9-a3f9-bc15-0f6b9c64302a"), "2265 Maureen Stream, Norrisville, Jersey", "Leone_Dickens@yahoo.com", "Ben", null, "Schultz", "(849) 627-6542", 3, null },
                    { new Guid("2186bf7c-adfd-f953-328a-06b15388143e"), "10075 Romaguera Run, South Gregg, Sweden", "Jermaine.Anderson@hotmail.com", "Terrence", null, "Gaylord", "1-744-529-1119 x8345", 3, null },
                    { new Guid("21e79ebc-15d9-533b-9078-d599c13d2d9b"), "850 Keara Meadows, Lake Paoloville, Svalbard & Jan Mayen Islands", "Celine_Connelly27@yahoo.com", "Willis", null, "Von", "591.934.3043", 2, null },
                    { new Guid("248fb1f2-f1fc-59bb-964e-ecae4f46a57c"), "41305 Logan Light, Arnoborough, Costa Rica", "Rowan3@yahoo.com", "Lane", null, "Conroy", "716-598-5844 x77758", 2, null },
                    { new Guid("262c214d-3fbe-3970-28f9-4ff6ff64ca7a"), "60412 Twila Center, Zboncakfurt, Iraq", "Leonora12@hotmail.com", "Rahsaan", null, "Schmitt", "282-495-8320 x07466", 1, null },
                    { new Guid("26fcfca7-6c6a-e507-39fa-4524df083e6f"), "745 Kautzer Pass, West Mohammad, Australia", "Jeanette.Weissnat45@gmail.com", "Effie", null, "Rath", "273-365-1536 x6410", 2, null },
                    { new Guid("287711bb-a6ce-e289-d1df-2bfd4f453694"), "422 Kenyatta Greens, Port Rosaleemouth, Peru", "Albin_Marquardt86@hotmail.com", "Rosalinda", null, "Champlin", "364.421.0478 x2739", 1, null },
                    { new Guid("292f1684-36c1-2068-c015-6f79dc6e1208"), "667 Stracke Squares, Damienberg, Moldova", "Margaret_Boyer@hotmail.com", "Melody", null, "Stamm", "(466) 651-7717 x68266", 2, null },
                    { new Guid("29901472-626e-c015-676c-429f1be96a43"), "3116 Rickie Square, Kareemland, Norway", "Madelyn_Hahn99@yahoo.com", "Delaney", null, "Langworth", "1-600-227-2664", 1, null },
                    { new Guid("2a2595a0-5601-b1de-6005-c55be17bac33"), "05603 McDermott Creek, South Colinfort, United Arab Emirates", "Meghan.Herman51@gmail.com", "Cullen", null, "Mann", "693-341-1857", 3, null },
                    { new Guid("2cfa1e66-cc87-a06b-5945-0ebfbd353c1d"), "72367 Grover Cliffs, South Vicenteton, Mali", "Valerie_Vandervort17@yahoo.com", "Liam", null, "Deckow", "995.870.8349", 2, null },
                    { new Guid("30273695-92ff-66ad-f25c-846eda48b6ca"), "106 Cremin Dam, North Joshuahmouth, Gambia", "Belle_Hegmann38@yahoo.com", "Jefferey", null, "Franecki", "1-393-450-4721 x27927", 2, null },
                    { new Guid("30caff52-a543-4e62-52c0-c65b22bf4494"), "17511 Prohaska Meadow, North Skyeshire, Brazil", "Jaylan_Gutkowski@gmail.com", "Lewis", null, "Crist", "551-779-9431 x6292", 1, null },
                    { new Guid("31221009-5f96-0f80-49a0-ef1191dae7a6"), "93876 Glover Hills, Gleasonside, Poland", "Dorian.Cronin92@hotmail.com", "Randi", null, "Fritsch", "(640) 246-7952 x5986", 2, null },
                    { new Guid("31c0ae67-e58d-5790-9143-0ced504ed9d6"), "1468 Kessler Islands, Manteland, Canada", "Edgar_Rogahn@hotmail.com", "Ben", null, "Wyman", "765-507-5651 x6211", 3, null },
                    { new Guid("33769b64-51bf-d764-0706-05db0305c645"), "850 Hermina Springs, Hettingerhaven, Kenya", "Cesar30@yahoo.com", "Wayne", null, "Johnson", "1-679-381-5080 x86624", 3, null },
                    { new Guid("342fd0d1-60de-af2b-2d7d-f1fcafccccca"), "139 Ritchie Track, Lake Alda, Mali", "Ben_Batz26@hotmail.com", "Jayson", null, "Deckow", "1-391-599-0909 x684", 1, null },
                    { new Guid("359c3d64-b261-a0fa-6af4-8d5549f752c6"), "61367 Cummings Plains, Wayneburgh, Germany", "Emilia.Harvey@hotmail.com", "Queen", null, "Russel", "(929) 411-9353 x82630", 3, null },
                    { new Guid("3658b3e9-3146-14df-4cbd-aef9f99011cc"), "62549 Heathcote Points, Ryanmouth, United States Minor Outlying Islands", "Sarai43@yahoo.com", "Retta", null, "Schmidt", "(375) 728-5669 x7819", 1, null },
                    { new Guid("36dec671-b191-20eb-5f47-4f78de593d0b"), "0874 Kihn Prairie, Kendallburgh, Tuvalu", "Einar26@gmail.com", "Giovanna", null, "Harber", "295-511-3694 x792", 3, null },
                    { new Guid("372ad942-7a4f-4e6d-3029-7b27cd8a5368"), "0853 Ziemann Branch, Lake Abelstad, Azerbaijan", "Virgil4@gmail.com", "Allison", null, "Runolfsson", "945-611-9144", 2, null },
                    { new Guid("38688037-4360-b563-c11e-02fa52836357"), "693 Jacobi Passage, Aricmouth, Hungary", "Alan95@hotmail.com", "Audie", null, "Pfeffer", "281.985.8555", 2, null },
                    { new Guid("388ba4d5-ed7b-b003-63c3-333c9df51d77"), "02942 Ariel Shoal, New Anna, Iceland", "Jaeden_Schuster41@hotmail.com", "Angelica", null, "Crona", "(844) 207-3446 x5435", 1, null },
                    { new Guid("3932528f-6e05-f7a5-04ff-2b568f613669"), "147 Hand Turnpike, Lakinfort, Gambia", "Garnett.Fay@hotmail.com", "Jaden", null, "Crooks", "926-779-3254 x01597", 3, null },
                    { new Guid("39aba7d9-0fc7-ff83-6bd6-d63abc974940"), "09274 Reed Park, East Desmond, Mozambique", "Armani.Hansen19@hotmail.com", "Alexzander", null, "Raynor", "1-664-503-2567 x092", 1, null },
                    { new Guid("3ae948ea-6b66-55c8-9c8f-4e938e888740"), "05494 Zboncak Plains, Lake Alexiefort, Angola", "Rowena87@hotmail.com", "Bernadine", null, "Davis", "447-298-7865 x797", 1, null },
                    { new Guid("3b7683bf-15c6-de39-fe7b-501036af0eb0"), "8200 Reilly Wall, Port Diana, Virgin Islands, U.S.", "Eli3@yahoo.com", "Lionel", null, "Renner", "717-468-3220 x78884", 2, null },
                    { new Guid("3c97d86f-80c3-5f49-91c5-2e02cbc8c67b"), "579 Predovic Place, Parisianhaven, Jamaica", "Simone.Hermann47@hotmail.com", "Marcelo", null, "Yundt", "(336) 286-2765", 1, null },
                    { new Guid("3e40238a-c97f-7d93-cf78-324990d1ad26"), "2463 Eldora Camp, Toneyland, Malaysia", "Oran.Hermiston65@gmail.com", "Barney", null, "Tromp", "(756) 400-6150 x459", 2, null },
                    { new Guid("3fbe5dee-2463-819d-a699-0d6151422839"), "6428 Jaskolski Junction, Kingchester, Mozambique", "Roderick_Greenholt80@gmail.com", "Everardo", null, "Hermiston", "542.425.6046", 3, null },
                    { new Guid("400562e6-4540-ff08-10a8-e9435b0a8b2b"), "28257 Ward Burgs, Lonieville, Armenia", "Gerry61@hotmail.com", "Amara", null, "Wehner", "551.413.3348", 1, null },
                    { new Guid("42368ef6-5ea0-bd19-c104-40eb33baaddf"), "59350 Collier Lights, North Elainaport, South Georgia and the South Sandwich Islands", "Irma18@yahoo.com", "Caden", null, "Spencer", "409.229.8017", 3, null },
                    { new Guid("427f315e-4e4c-65c6-33f7-8bc823528c64"), "9734 Merle Crescent, West Joesph, Eritrea", "Eloisa7@hotmail.com", "Deborah", null, "Kiehn", "1-767-683-4348", 2, null },
                    { new Guid("4369cb58-d228-4b06-bb1e-0f1d1cadd1e5"), "456 Karli Lodge, Edisonchester, Anguilla", "Charley_Harvey33@hotmail.com", "Gabrielle", null, "Koch", "200.285.0766 x29021", 3, null },
                    { new Guid("44232d76-5f05-58b8-1880-c707df381386"), "705 Anahi View, Murazikfort, Christmas Island", "Sebastian80@hotmail.com", "Reed", null, "Yost", "494.398.6365", 1, null },
                    { new Guid("44b22a0d-3619-d347-98c5-de4f7be80484"), "4947 Kolby Mountain, Lake Rhianna, Chile", "Antoinette_Brekke@gmail.com", "Eva", null, "Kilback", "1-254-354-9949", 3, null },
                    { new Guid("454983da-48c3-cd1d-d223-5039f59be3c0"), "052 Lehner Expressway, Schulistmouth, British Indian Ocean Territory (Chagos Archipelago)", "Rahul.Cronin45@yahoo.com", "Misael", null, "Bradtke", "351-313-9247 x8633", 3, null },
                    { new Guid("49d80853-691e-ec9b-3a85-d2a85a97f2c6"), "94394 Jalen Point, Stephanmouth, San Marino", "Katelynn_Farrell@gmail.com", "Iva", null, "Shanahan", "404-450-4192 x7997", 1, null },
                    { new Guid("4a13eeea-41b3-0bd9-bb0e-d4e5dbeed28d"), "60414 Zulauf Curve, New Kayleigh, Gibraltar", "Taya34@gmail.com", "Waldo", null, "Krajcik", "1-777-676-6084", 2, null },
                    { new Guid("4ade8b68-866b-6398-bbd9-22129e0598bc"), "663 Cole Ridges, Brandttown, Togo", "Annabell0@hotmail.com", "Zelma", null, "Shanahan", "(431) 359-9675 x94014", 3, null },
                    { new Guid("51961631-bf81-fba2-45af-ae31ab672554"), "501 Rocky Locks, Fatimashire, Angola", "Kayley31@hotmail.com", "Lorena", null, "Reilly", "809-291-2839 x39091", 1, null },
                    { new Guid("52cfbafc-af50-4da6-c276-b1bc71823fed"), "249 Electa Track, Cameronhaven, France", "Eloy78@yahoo.com", "Marisa", null, "Hyatt", "284-557-1501", 2, null },
                    { new Guid("55b7c60f-6f04-7c86-5309-7f937faacf30"), "535 Jasmin Pine, Reichertview, Netherlands", "Taya_Boyle94@yahoo.com", "Cloyd", null, "O'Reilly", "(435) 326-2505 x4458", 3, null },
                    { new Guid("57bc4634-9c16-de0b-d25d-74f0a77d9fec"), "9033 Abigayle Inlet, Hilperttown, Liechtenstein", "Chaim_Mante@gmail.com", "Johnathan", null, "Turner", "(481) 442-1996", 1, null },
                    { new Guid("57caf2ce-4713-1fb6-48ad-f7906816a121"), "61362 Carrie Viaduct, West Myriam, Serbia", "Grayson_Kuhn92@hotmail.com", "Bradford", null, "Schaden", "1-504-864-5308", 1, null },
                    { new Guid("58602e48-e6b7-c9c3-266c-010ca36ca2b7"), "34761 Reichel Knoll, Bettiestad, France", "Modesto.Will65@gmail.com", "Agustin", null, "McKenzie", "705-289-9542 x5296", 3, null },
                    { new Guid("5941a0fe-b530-d1cf-fc9d-29ec93c7ea7c"), "46616 Clement Court, Kihnfurt, Lithuania", "Jillian.Mosciski99@yahoo.com", "Letitia", null, "Reynolds", "469-339-1867 x0251", 1, null },
                    { new Guid("5b46f9c5-78ec-0d95-2a4e-f0182f24e1f9"), "27588 Rice Haven, Pfannerstillland, Indonesia", "Margarita.Bosco68@yahoo.com", "Merritt", null, "Hodkiewicz", "279-432-7730 x6788", 2, null },
                    { new Guid("5dcd118e-5391-3dad-0e4c-a1c6a8bf7c83"), "0652 Cummerata Spring, Raheemland, Germany", "Francesco_Denesik@hotmail.com", "Kade", null, "Borer", "(656) 524-1413 x7491", 1, null },
                    { new Guid("610c0250-24c4-bbc7-e5a7-1224b8d4f6d4"), "40258 Jayda Glens, Aramouth, Nicaragua", "Jessica_Welch11@gmail.com", "Moses", null, "Weimann", "(499) 972-6496 x7830", 1, null },
                    { new Guid("625c34a8-4fcd-ac02-f651-c941d3b58221"), "50366 Bogan Lodge, Alexzandermouth, Guam", "Chauncey.Goyette@yahoo.com", "Darius", null, "Von", "1-863-996-0938", 3, null },
                    { new Guid("638cd153-26b3-5db3-43da-0a13708b642a"), "86317 Cody Crossroad, Carissaborough, Malaysia", "Letha.Witting@yahoo.com", "Julianne", null, "Mertz", "1-864-982-1963 x6945", 1, null },
                    { new Guid("63c53a7d-25fb-57c3-f03d-743153384ddf"), "4781 Nitzsche Pike, Leuschkechester, Iraq", "Everette.Bergstrom96@yahoo.com", "Dustin", null, "Sawayn", "856-858-8649 x8564", 2, null },
                    { new Guid("66173a32-d8d3-92a5-2134-906fad885de7"), "42568 Orlando Drives, Martinechester, San Marino", "Hazle83@yahoo.com", "Elijah", null, "Towne", "726.939.8076", 2, null },
                    { new Guid("670c1196-8c71-5780-f4da-2bedf6ef23c7"), "942 Caesar Corner, Blancheberg, Bosnia and Herzegovina", "Eula65@hotmail.com", "Alaina", null, "Gulgowski", "(941) 566-9986 x55716", 3, null },
                    { new Guid("67297d5f-972b-f276-05f4-804714cfcece"), "42752 Yasmine Meadows, Port Charity, Norfolk Island", "Victoria.Hamill@gmail.com", "Jodie", null, "Leannon", "553.668.7817 x51058", 2, null },
                    { new Guid("697a95a0-e671-804d-1c00-570efc8c4d6e"), "512 Deondre Isle, Port Matteo, Kyrgyz Republic", "Marcos_Littel51@gmail.com", "Jarrett", null, "Schmeler", "833.790.8700 x78857", 3, null },
                    { new Guid("697bc8f9-1a84-aaeb-323b-5b63dbd70465"), "96660 Velda Mill, Bayerville, Madagascar", "Rhett3@gmail.com", "Danyka", null, "Quitzon", "(417) 872-0216", 2, null },
                    { new Guid("6991d5af-787a-f09b-506f-c216b9503583"), "65763 Jaida Junction, West Jimmieport, Maldives", "Emmie23@hotmail.com", "Gay", null, "McCullough", "872-655-0247 x85855", 2, null },
                    { new Guid("69a800b9-0011-a1cf-475b-cd2a200d758b"), "981 Aron Hill, New Mafalda, San Marino", "Nelle_Dibbert@hotmail.com", "Kayley", null, "Wuckert", "999-760-7484", 1, null },
                    { new Guid("6b0dd75a-db2f-121a-4868-7531a90c81a9"), "87056 Sid Forest, Jonatanview, Switzerland", "Rhoda.Homenick@gmail.com", "Adelle", null, "Kling", "1-838-244-0646", 2, null },
                    { new Guid("6c24e5bb-894e-37a4-027b-a0d2f56c615d"), "0154 Carolyne Row, Parkertown, Cocos (Keeling) Islands", "Myrl.Dickinson@gmail.com", "Tracy", null, "Kreiger", "1-824-690-4601 x5979", 1, null },
                    { new Guid("6c6456e1-38a7-6ae1-d746-205742bc847f"), "183 Finn Point, Kulaston, Slovenia", "Marcia_Larkin18@gmail.com", "Melvina", null, "Pfeffer", "464.791.2531 x314", 1, null },
                    { new Guid("6cdf635d-9a1b-72d4-86a3-4e7a4e429e12"), "568 Conn Hollow, Hayesmouth, Saint Barthelemy", "Imogene_Spencer@gmail.com", "Evans", null, "Larson", "1-354-942-3071", 3, null },
                    { new Guid("6dea2c8c-33ed-b3ae-6b71-7718b7df8b55"), "9791 Kuvalis Shores, Port Dashawnborough, Bahamas", "Nella34@hotmail.com", "Milton", null, "Bailey", "221.459.4488 x864", 3, null },
                    { new Guid("7008032c-f119-8fd7-181e-cb0812659c9e"), "07066 Baumbach Run, South Skylarmouth, Kiribati", "Barrett.Smith87@hotmail.com", "Preston", null, "Kemmer", "(314) 883-6613 x69646", 3, null },
                    { new Guid("721a05fb-91b5-2d5f-14b6-e1ce7f64fc9b"), "099 Schaefer Tunnel, Ebbamouth, Gibraltar", "Kacie.Ryan@hotmail.com", "Hailie", null, "Wehner", "1-486-393-9573 x8460", 1, null },
                    { new Guid("75473389-a83a-c08d-448a-9a531a36b018"), "726 Elinore Trace, Port Bradenfort, Pakistan", "Lavon.Lemke@hotmail.com", "Broderick", null, "Greenholt", "1-224-301-5101 x93591", 3, null },
                    { new Guid("75708e67-3888-146e-f48c-5cfa93a74456"), "71561 Sherman Cliffs, Kamillechester, Iraq", "Ernest24@hotmail.com", "Rosalinda", null, "Dietrich", "1-463-618-0964 x01577", 1, null },
                    { new Guid("77139307-05d8-7e72-9ab4-fc1bf12073be"), "8377 McCullough Brook, Gloverfurt, Ireland", "Augusta.Armstrong72@yahoo.com", "Lawrence", null, "Schneider", "(504) 378-7296 x2815", 1, null },
                    { new Guid("7844e230-9930-cfdd-d6b1-989863187def"), "088 Elvis Corner, North Alexzanderfurt, Saudi Arabia", "Jimmy96@gmail.com", "Emilia", null, "Nader", "511-201-9586 x39686", 2, null },
                    { new Guid("79675bb9-e3c8-cd20-b88f-7d7b93baac4d"), "91722 Hackett Path, Carolyneborough, Ukraine", "Winston.Walker@yahoo.com", "Noah", null, "Nitzsche", "1-777-695-2424", 1, null },
                    { new Guid("7a982cad-06d5-6a0f-c189-95fc9a1a76de"), "8399 Brody View, Katelynstad, Iran", "Kari9@yahoo.com", "Briana", null, "Pouros", "507-964-4170 x4454", 1, null },
                    { new Guid("7bb9307d-f8e1-c123-2475-94f6f59f31be"), "8721 Nicolas Lodge, Klingmouth, Venezuela", "Reece.Ullrich@hotmail.com", "Jo", null, "Stamm", "709-428-6068 x5943", 3, null },
                    { new Guid("7db5fa8e-807a-eea6-5ea6-99cc41e4d70f"), "24952 Gusikowski Locks, New Nathanaelshire, Qatar", "Luisa_Durgan74@hotmail.com", "Emanuel", null, "Jenkins", "467-350-3319", 3, null },
                    { new Guid("7fc2116a-7f4a-e5fd-1bb0-cc61204c3e15"), "9329 Renner Village, Kacihaven, Lithuania", "Caterina47@yahoo.com", "Antonina", null, "Rice", "(205) 450-0396 x2090", 3, null },
                    { new Guid("805c512d-678f-5be2-6846-f2ce7c1d7625"), "8516 Runolfsdottir Hill, Kundetown, Cameroon", "Karina75@hotmail.com", "Reese", null, "Hahn", "(428) 822-8514 x759", 1, null },
                    { new Guid("80b22c5a-168e-622a-6c24-75a0c12606d6"), "245 Constance Brooks, East Naomiburgh, Seychelles", "Jarred_OReilly@yahoo.com", "Megane", null, "West", "201-273-2870", 3, null },
                    { new Guid("810e2244-8df8-f249-a151-c7e0195b318c"), "889 Sauer Dam, North Octaviastad, Solomon Islands", "Austen.Wilkinson@gmail.com", "Bailey", null, "Schaden", "760-900-9361 x5468", 2, null },
                    { new Guid("815dca5f-11d6-224d-3d58-4bfb231745a1"), "7976 Roob Squares, Brianton, Norway", "Oral_Denesik34@gmail.com", "Maritza", null, "Wuckert", "615-538-2818", 1, null },
                    { new Guid("8339fdd2-9b03-0345-878d-129746d05418"), "990 White Pines, East Veronica, Chad", "Tito.Yost42@yahoo.com", "Aliza", null, "Langworth", "1-474-507-2431", 3, null },
                    { new Guid("839177b0-11c6-5298-e9b2-f8c2cecc2859"), "227 Roderick Mission, North Malachi, Jordan", "Wilburn.Rippin15@gmail.com", "Ilene", null, "Gorczany", "1-357-494-9293", 2, null },
                    { new Guid("8410350e-76ce-ccae-8610-b884117b2291"), "1218 Boehm Dale, Aracelyshire, Rwanda", "Paolo_Shields@yahoo.com", "Roscoe", null, "Little", "(571) 836-7599 x575", 2, null },
                    { new Guid("842dccc7-93bb-60e4-dbda-ce03864c30dd"), "711 Romaguera Keys, New Mateo, Saudi Arabia", "Jaylon_Conn@gmail.com", "Lexi", null, "Pfannerstill", "823-385-6721 x08663", 3, null },
                    { new Guid("84502662-d1ef-49aa-ef6c-d54d6bd9c6f8"), "48461 Damian Extensions, Ansleystad, Equatorial Guinea", "Tristin98@yahoo.com", "Julia", null, "Beer", "671-596-1357 x233", 1, null },
                    { new Guid("84a1a761-8bf6-eed1-90a4-38464ae410eb"), "814 Kris Summit, East Jarredfort, Suriname", "Brandon.McGlynn@gmail.com", "Zora", null, "Herzog", "767.846.6510 x826", 1, null },
                    { new Guid("857f8131-92e6-6c0c-c55f-3684403128d6"), "3800 Brandy Centers, Wolftown, Germany", "Elisha_Nolan@hotmail.com", "Neva", null, "Kutch", "1-434-956-2201", 3, null },
                    { new Guid("857fae46-84b6-4bd3-e409-9676f2b0fd73"), "784 Sheldon Gardens, East Bridget, Chile", "Madilyn.Purdy@yahoo.com", "Darrel", null, "Prohaska", "(681) 650-3716 x40403", 3, null },
                    { new Guid("86aa8cde-d480-b3e3-1207-7501eed414db"), "1566 Little Turnpike, North Cheyanne, Turkmenistan", "Judson78@gmail.com", "Rosamond", null, "Vandervort", "486.476.4608 x247", 2, null },
                    { new Guid("86e28ff1-994e-9127-c179-d7bcf1cf1021"), "821 Quentin Mountain, West Aishaland, United States Minor Outlying Islands", "Florence68@yahoo.com", "Jessy", null, "Predovic", "509.464.5134 x635", 3, null },
                    { new Guid("879eacfc-f487-b411-0aa0-3b01a22b187d"), "2489 Huel Ridges, Willmsberg, Vanuatu", "Green_Abernathy@gmail.com", "Jesse", null, "Casper", "927-994-5010", 2, null },
                    { new Guid("8859d867-746c-ed78-742e-75c1b39fc45c"), "0938 Conrad Groves, Lake Emiebury, Republic of Korea", "Ayana.Leffler77@hotmail.com", "Dangelo", null, "Gorczany", "824-543-5712 x043", 2, null },
                    { new Guid("8999c31e-6dcd-ebc0-72f3-9eb0aabacb14"), "398 Waters Stream, Collinsshire, Hungary", "Mozell_Schmidt@gmail.com", "Cathryn", null, "Dickinson", "752.214.7981 x6089", 1, null },
                    { new Guid("966756ef-6eb5-106d-9b5d-b5630f6c4448"), "0392 Cordelia Village, Port Bransonland, Luxembourg", "Hunter56@hotmail.com", "Jakob", null, "Thompson", "977.810.0038 x664", 2, null },
                    { new Guid("982f3f95-8da0-1e27-68bb-9200ba2995a0"), "9124 Kyler Island, Alvahmouth, Russian Federation", "Lea2@gmail.com", "Sister", null, "Kuphal", "1-874-964-4866 x9289", 3, null },
                    { new Guid("9954dd74-dd5e-3561-3bad-d6b2917a050b"), "83105 Adan Ranch, North Ron, Jamaica", "Westley_Kassulke@yahoo.com", "Hallie", null, "Johnston", "1-773-470-1797 x53774", 2, null },
                    { new Guid("9d149fc8-94d7-3265-a816-9b6fd33da63b"), "01506 Macie Common, Maggiofurt, French Southern Territories", "Jaime_Blanda67@hotmail.com", "Izabella", null, "Sipes", "817-465-5053", 2, null },
                    { new Guid("9dc30acf-2649-9822-eb75-9f5a3ebf5657"), "6693 Camilla Rapid, Emmietown, Cambodia", "Quincy74@yahoo.com", "Jonathon", null, "Stroman", "1-593-387-4285", 3, null },
                    { new Guid("a0413dd5-f04b-bd10-6b38-f22fe42e8ab6"), "64144 Rebekah Curve, Wymanbury, Denmark", "Peyton.Reichert77@yahoo.com", "Dana", null, "Hane", "(665) 638-8263", 1, null },
                    { new Guid("a067d22b-7eac-20c3-ee80-916fad5ec69f"), "65201 Alexa Villages, New Marcelle, Wallis and Futuna", "Michael50@hotmail.com", "Gunnar", null, "Thiel", "597-274-4986", 3, null },
                    { new Guid("a3310193-ee09-dcea-f518-8415559f6302"), "486 Strosin Radial, Lake Salma, Armenia", "Zander73@hotmail.com", "Wilhelm", null, "Waelchi", "(350) 542-2663 x8965", 3, null },
                    { new Guid("a421b820-6314-79c4-0839-cbfc6a891de0"), "72712 Skiles Villages, Lake Domenick, Cayman Islands", "Agustina42@yahoo.com", "Carey", null, "Bogisich", "(719) 474-8810", 2, null },
                    { new Guid("a541b00e-4cb3-4869-0925-b788e39b61c7"), "394 Thompson Ville, East Evafurt, Montserrat", "Jena.Price16@yahoo.com", "Pearlie", null, "Schuster", "516-830-5104", 3, null },
                    { new Guid("a5cdb376-49c8-eb32-e6c2-e280a9a7b014"), "900 Jimmie Isle, Port Jaycee, Myanmar", "Aryanna_Howe@gmail.com", "Jacynthe", null, "VonRueden", "(783) 844-8149 x19059", 2, null },
                    { new Guid("a61409c0-ddcf-0768-2658-119aed428f49"), "213 Priscilla Fork, New Ron, Eritrea", "Helena.Douglas78@hotmail.com", "Keshaun", null, "Kshlerin", "528.674.0565 x026", 1, null },
                    { new Guid("a64f55aa-89e4-88c5-2ccb-e40a669cc013"), "40730 Kayleigh Bridge, Hartmannfurt, Niger", "Emerson.Boyer91@hotmail.com", "Laurie", null, "Heathcote", "303.279.5714 x281", 3, null },
                    { new Guid("a6ad2da5-056a-d1eb-eaeb-ac5572c64cf1"), "15040 Nikolaus Summit, Larkinstad, Greenland", "Jeffry_Stark26@gmail.com", "Chet", null, "Ratke", "1-290-499-1325 x02763", 2, null },
                    { new Guid("aaf3d1f6-67cc-a902-a151-af4f66e8389f"), "8078 Miles Trail, West Edgarfurt, Egypt", "Charity34@hotmail.com", "Alyson", null, "Kulas", "492.920.5333 x4356", 1, null },
                    { new Guid("ac01749e-ea94-dd97-7d42-cd879fd945fc"), "96722 Brad Ford, New Jettie, Egypt", "Alanna.Rempel@yahoo.com", "Allan", null, "Schneider", "746.362.5472", 3, null },
                    { new Guid("ac558501-fafe-ccfc-52bd-03122382c12a"), "8068 Wade Lodge, Hamillhaven, Syrian Arab Republic", "Julien43@yahoo.com", "Darron", null, "O'Kon", "(363) 849-8173 x53544", 3, null },
                    { new Guid("ae2330be-3194-44e2-f567-b380bec0594f"), "3460 Autumn Roads, Padbergland, Cape Verde", "Candida_Pouros70@hotmail.com", "Reyna", null, "Mann", "614.961.9646", 3, null },
                    { new Guid("b03cfd40-7f52-3ca9-fc50-80f1d40ab726"), "083 Yesenia Hills, North Kara, Iran", "Anjali_Kirlin@hotmail.com", "Name", null, "Hand", "(679) 311-8519 x77000", 2, null },
                    { new Guid("b1ef9173-0e85-4adc-700d-eb7dbc240d98"), "159 Blanda Lodge, Hettingerchester, Pitcairn Islands", "Arden33@hotmail.com", "Selina", null, "Anderson", "385-901-1420 x428", 1, null },
                    { new Guid("b2220394-288e-edaa-ea22-0c6994da76b7"), "8567 Keven Freeway, Amiestad, French Guiana", "Xander.Wunsch@gmail.com", "Anjali", null, "Medhurst", "328.380.4217 x681", 1, null },
                    { new Guid("b25d20a9-383c-79ef-46bf-c89e5a02a61f"), "83076 Courtney Junction, Port Arielport, Brunei Darussalam", "Joshuah.Thompson@gmail.com", "Sylvan", null, "Lakin", "(949) 304-9807 x48518", 2, null },
                    { new Guid("b3a499b7-0dfb-baa3-ab63-a27007794a48"), "6031 O'Connell Stravenue, North Alison, Haiti", "Heath.Berge42@hotmail.com", "Rosie", null, "Goodwin", "273.841.3147 x72149", 1, null },
                    { new Guid("b50b763f-c5a5-b97c-1e80-e275fd9c06f6"), "2938 Shields Keys, East Anabeltown, Bouvet Island (Bouvetoya)", "Kelsie.Herman@gmail.com", "Lucio", null, "Smitham", "591-281-3632 x40172", 3, null },
                    { new Guid("b5b9ac87-ea81-a986-263c-bc6df3b189d2"), "936 Kris Freeway, Port Kaylamouth, Taiwan", "Delpha8@gmail.com", "Merle", null, "White", "896-557-9051 x171", 2, null },
                    { new Guid("b68d4642-e360-c990-2313-f0d56421373b"), "672 Ryan Drives, North Staceystad, Antigua and Barbuda", "Aurelio_Hilpert31@gmail.com", "Chloe", null, "Wolff", "988.765.4734 x8902", 1, null },
                    { new Guid("b6ae1c98-a1d2-774a-7fa9-ad9ab596ce5c"), "305 Pouros Burg, Gerholdberg, Nauru", "Kaci47@yahoo.com", "Shayna", null, "Hessel", "(562) 236-5714 x020", 1, null },
                    { new Guid("b8d5b325-dbb4-7387-e837-c4390a97f45d"), "851 Madisyn Stream, North Devenfort, Canada", "Lera9@hotmail.com", "Parker", null, "Keeling", "797-692-2686 x8570", 2, null },
                    { new Guid("b8fa74bc-6271-89f6-063d-3723d170fbd1"), "93730 Leatha Club, South Antone, Slovenia", "Andy90@gmail.com", "Frida", null, "Von", "395.824.2607", 2, null },
                    { new Guid("b936cb2e-24f5-d22e-30c0-7b97fcbb1be7"), "0954 Koepp Ridge, Cummeratastad, Pakistan", "Monique_Bahringer@hotmail.com", "Mariela", null, "Sipes", "(606) 667-7966", 1, null },
                    { new Guid("bab251ed-a5ca-3db2-9c7f-615588080945"), "88829 Wyman Corners, Borermouth, Kuwait", "Jacques63@yahoo.com", "King", null, "Hamill", "486-650-8011 x80480", 1, null },
                    { new Guid("bb0faffb-14a0-6db7-de32-0106354effac"), "50892 Tromp Crossing, Gloverside, Lebanon", "Kaycee_Gutkowski63@yahoo.com", "Joesph", null, "Block", "396.955.2092 x770", 2, null },
                    { new Guid("bb4d98ec-f4b4-37e0-2a3a-a14d7303f120"), "0113 Graciela Island, Port Averyfurt, Mauritius", "Chaim51@gmail.com", "Noah", null, "Roob", "717-957-7494 x67377", 3, null },
                    { new Guid("bbc2d455-1965-c9c0-010b-aa8404e17a8f"), "325 Keely Coves, South Agustina, Philippines", "Lydia_Lowe@yahoo.com", "Raleigh", null, "Schneider", "(308) 210-8337 x1696", 1, null },
                    { new Guid("bc20b242-4745-4a08-bd8c-cdece4f41d23"), "7166 Aniya Vista, Zulaufview, Greenland", "Isaac_Monahan96@hotmail.com", "Vada", null, "Thiel", "(746) 965-8468", 2, null },
                    { new Guid("be3ad6aa-fcf0-2a3b-8dec-f6db05fa394f"), "7072 Lemuel Crossing, East Diana, Greece", "Hilton_Roberts@gmail.com", "Madilyn", null, "Brakus", "(650) 279-4667 x90932", 2, null },
                    { new Guid("bf351203-2e27-be84-6657-ab45e54ef994"), "991 Lang Unions, East Jasenland, Niue", "Uriah.Deckow@yahoo.com", "Kristian", null, "Glover", "417.704.0169 x21728", 1, null },
                    { new Guid("bfb07723-14db-f5ba-c54e-d80adfd0bfda"), "960 Mafalda Light, Walterberg, Turkmenistan", "Frank30@gmail.com", "Vernon", null, "Russel", "524-999-3154", 2, null },
                    { new Guid("c02f1d4b-79ac-c8d3-11b4-8d206ba3e01c"), "87839 Darion Forge, Leopoldhaven, Japan", "George_Marvin@yahoo.com", "Alia", null, "Hartmann", "880-786-1801 x23805", 2, null },
                    { new Guid("c0a9fc0f-bb6e-b2f4-2b46-bebd6356318b"), "7471 Rodriguez Roads, New Gunnerberg, Georgia", "Missouri.Sanford@hotmail.com", "Isabella", null, "Barrows", "1-903-786-2808", 1, null },
                    { new Guid("c28c62e9-b428-09cf-b60b-9ddb08154b91"), "194 Keeling Glen, Bettyefort, New Zealand", "Kaitlin_Will76@gmail.com", "Nathanael", null, "Rosenbaum", "1-660-287-1747 x16230", 3, null },
                    { new Guid("c3a7f1c4-d39c-e25a-f308-c81612cc58cb"), "458 Eino Ranch, Port Antoinettestad, Georgia", "Edmund.Collier@gmail.com", "Carlee", null, "Brown", "(583) 901-5492 x97456", 3, null },
                    { new Guid("c3cc743c-46ac-c7b7-f671-be361def3e65"), "26420 Kreiger Lodge, West Prudence, Netherlands", "Chandler.Connelly15@hotmail.com", "Elva", null, "Ondricka", "664.404.3472", 2, null },
                    { new Guid("c7b932a8-59ad-9392-be49-4228b0b13ae1"), "73676 Prosacco Mountain, East Evan, Armenia", "Kimberly.Hamill@gmail.com", "Mercedes", null, "Runolfsson", "(981) 595-7340 x839", 1, null },
                    { new Guid("c825ca37-892b-3c8c-a3de-a46af0b3dd1b"), "27980 Mae Brook, East Kaialand, Kenya", "Tamara31@yahoo.com", "Jacques", null, "Russel", "1-978-468-6478 x7814", 2, null },
                    { new Guid("c8d0291b-c666-2481-bb07-86cc00de99d3"), "1667 Sarah Row, Port Hobartside, Saudi Arabia", "Carson.Marquardt@gmail.com", "King", null, "Upton", "1-866-278-6956 x526", 2, null },
                    { new Guid("ca1a1485-d879-6f3f-860c-76b6af81131d"), "14559 Orn Forges, New Elvera, Andorra", "Wiley_Kautzer53@hotmail.com", "Domenic", null, "Cruickshank", "769.618.5365 x015", 2, null },
                    { new Guid("ca89163e-21d4-4510-7c6a-961ddf210c12"), "518 Wisozk Fields, North Paulinechester, Malawi", "Linnie50@yahoo.com", "Jessyca", null, "Mosciski", "284-202-0349", 1, null },
                    { new Guid("cb78de15-407d-62de-cadd-81e8cb70ca9d"), "535 Lynn Branch, Walkerborough, American Samoa", "Chelsie_Monahan@gmail.com", "Baron", null, "Spinka", "(300) 325-2354", 1, null },
                    { new Guid("cbb774e1-e565-3319-8f97-11dacf5c5fd1"), "2976 Sheila Flats, North Jaymeberg, Russian Federation", "Ashtyn48@gmail.com", "Gregorio", null, "Ortiz", "726-652-1369 x41807", 2, null },
                    { new Guid("cf3f7034-6294-ea0a-6974-1ba447ba33f0"), "529 Romaguera Villages, Quitzonside, Suriname", "Tabitha5@yahoo.com", "Albert", null, "Orn", "479.385.6200 x685", 1, null },
                    { new Guid("d16dd78b-0a8e-6295-b19f-8d7d9b5e225d"), "38352 O'Keefe Motorway, Robertsview, Ireland", "Berta5@hotmail.com", "Germaine", null, "Zulauf", "1-965-567-9161 x61608", 2, null },
                    { new Guid("d26bb6a1-4921-e9f9-57af-ddb3c18b87c5"), "44477 Heidenreich Crossroad, Cruickshankfort, Bolivia", "Gwen.Collins@yahoo.com", "Kendrick", null, "Luettgen", "888.214.1528 x83951", 1, null },
                    { new Guid("d72fa178-f2db-7f82-9de7-45f883632664"), "2336 Bradford Valleys, Shanaland, Belgium", "Kamren.Ward33@yahoo.com", "Desiree", null, "O'Reilly", "950.555.3455", 3, null },
                    { new Guid("d8259929-6624-5cc3-33c0-256195fd0bad"), "37782 Bradley Prairie, Lake Ricoberg, Australia", "Leta12@yahoo.com", "Mitchel", null, "Stehr", "1-954-544-7150", 2, null },
                    { new Guid("d93fa46d-55d9-8cac-98e5-d5ffe6d26bd9"), "611 Kihn Motorway, Lake Frankieton, Suriname", "Ethan.Lakin@yahoo.com", "Thad", null, "McGlynn", "272.745.1705 x401", 2, null },
                    { new Guid("dad19072-7a5d-cf63-7af5-04b7c1048930"), "04771 Johnson Circles, Port Lyric, Eritrea", "Lilly84@yahoo.com", "Katheryn", null, "Kreiger", "(906) 511-2736 x959", 1, null },
                    { new Guid("db9c8ced-ffe1-937f-1622-9221d2d68fc7"), "454 Milton Roads, Destiniside, Suriname", "Omer24@gmail.com", "America", null, "Bauch", "(494) 455-3840 x7490", 3, null },
                    { new Guid("dbda2bc2-10f7-e92c-46d8-62426000cb4d"), "80107 Frank Plain, Lake Otho, Cuba", "Alejandra56@hotmail.com", "Norwood", null, "Watsica", "(857) 821-6310 x0279", 2, null },
                    { new Guid("dd68b929-c181-6dd4-f849-17e7b73cadb1"), "94568 Trace Brooks, North Rodland, Estonia", "Polly.Grant@hotmail.com", "Paxton", null, "Doyle", "875.315.9296 x01381", 1, null },
                    { new Guid("dd893958-9b36-89fc-1c54-837e435ae8a5"), "18362 Hayes Club, Gorczanybury, Saudi Arabia", "Alessandra.Emmerich22@gmail.com", "Karson", null, "Bins", "232-622-5666 x07557", 1, null },
                    { new Guid("de529483-4eec-eda4-de49-b25f78394339"), "7209 Towne Curve, Powlowskiside, Belarus", "Annabel.Howell55@gmail.com", "Dimitri", null, "Stracke", "718.838.5278 x940", 2, null },
                    { new Guid("e314d593-bc80-1509-07fe-a8e41c3a9aa4"), "129 Bethel Junctions, East Alfmouth, Reunion", "Willa16@hotmail.com", "Mina", null, "Kautzer", "(395) 817-0451 x2202", 3, null },
                    { new Guid("e390ef18-11e1-34a1-62d2-e62a0b688808"), "598 Bayer Ville, South Kaylinville, Dominica", "Otilia_Bins37@hotmail.com", "Cullen", null, "Konopelski", "561-359-4818 x23585", 3, null },
                    { new Guid("e42e8e32-57b6-ad35-ee64-d53a84ddda62"), "749 Jerde Valley, Hackettberg, Libyan Arab Jamahiriya", "Della_Baumbach47@gmail.com", "Aniya", null, "Goldner", "819.978.3677 x4521", 2, null },
                    { new Guid("e53ff1a4-8367-8270-109a-4de0821b6ac0"), "163 Harber Freeway, Strosinton, Sri Lanka", "Fern_Zieme10@yahoo.com", "Kianna", null, "Stokes", "979-905-1906", 1, null },
                    { new Guid("e5ed11c4-b795-fc5b-aee8-48780b360371"), "706 Heloise Mews, Jarodburgh, Thailand", "Leanna.Schneider@gmail.com", "Mikayla", null, "Swift", "653.488.3064", 1, null },
                    { new Guid("e73e9407-e734-a0e2-444e-cf3f7fadadfa"), "81677 Kory Forges, East Henderson, Cape Verde", "Frieda96@hotmail.com", "Duane", null, "Block", "283.676.5372", 1, null },
                    { new Guid("e8c911d2-f3c4-cc68-d6c5-f9e339c7efc6"), "40807 Mante Square, Danielashire, Kazakhstan", "Marshall_Harvey91@yahoo.com", "Sigurd", null, "Weissnat", "(439) 708-7268 x9596", 3, null },
                    { new Guid("e936ad85-8afa-61c7-de0d-61eaa229d839"), "0939 Dickens Crest, Lake Aratown, Uganda", "Lempi68@gmail.com", "Jonathon", null, "Weissnat", "1-699-322-0349", 3, null },
                    { new Guid("e9e7929a-8a59-2817-ca1c-9383ab0fd3ff"), "85655 Clyde Harbor, Lake Calebfurt, Lebanon", "Nedra61@gmail.com", "Billie", null, "Schmidt", "(354) 990-6033", 3, null },
                    { new Guid("ea5ea0ba-ca99-953a-09dc-944b394b0e83"), "785 Laverna Junction, West Andy, Kazakhstan", "Ervin_Huels82@yahoo.com", "Fermin", null, "Homenick", "913.670.6682 x10273", 2, null },
                    { new Guid("eaf7d344-cb37-64e1-77b7-5313ae2f38cc"), "723 Daren River, North Elissa, Finland", "Eve.Keeling@hotmail.com", "Myrtie", null, "Wiegand", "416-528-2695", 1, null },
                    { new Guid("ecc07b06-0257-874b-8487-fa5be3040760"), "86133 Flatley Divide, Kuvalishaven, Nigeria", "Clemens.Okuneva61@hotmail.com", "Karli", null, "Schuppe", "349.431.0096 x9369", 3, null },
                    { new Guid("ee2da4ec-09a7-6ed8-1b94-676a189906aa"), "29221 Mariano Springs, Lake Tiachester, Indonesia", "Rosalyn_Bartoletti@gmail.com", "Nyasia", null, "Durgan", "(618) 427-5656 x7328", 2, null },
                    { new Guid("f016dfe9-0aa9-1a3a-c90b-02d029dd528b"), "8029 Ozella Stream, Lake Nakiafort, Antarctica (the territory South of 60 deg S)", "Joey33@yahoo.com", "Jimmy", null, "Hodkiewicz", "852-446-0722 x309", 2, null },
                    { new Guid("f07d3212-3571-960a-1fe7-b5173889ddaf"), "612 Maddison Ports, South Chancehaven, Dominica", "Kaley64@gmail.com", "Giuseppe", null, "Schoen", "1-820-207-9654", 1, null },
                    { new Guid("f2023bcd-6252-ad43-9174-02332c31b8ae"), "07366 Leffler Track, Manleyport, Croatia", "Shaun_Nicolas88@hotmail.com", "Oswaldo", null, "Grant", "(367) 389-5070 x1655", 1, null },
                    { new Guid("f4831008-3c08-b7cf-0f9e-aae807affaff"), "1669 Dorris Road, Bennettchester, Honduras", "Betty_Walsh80@gmail.com", "Monserrate", null, "Reichert", "385.414.9113 x8466", 1, null },
                    { new Guid("f63e33f9-7f5d-7f52-fe05-9ae26c0f206c"), "8934 Alexys Glen, Ludwigfurt, Turks and Caicos Islands", "Dorcas.White65@gmail.com", "Don", null, "Hansen", "800.881.1230", 3, null },
                    { new Guid("fc9cae13-76f9-5e0b-16ed-931aa60709e6"), "279 Haley Union, Angelicaside, Ecuador", "Providenci66@yahoo.com", "Alvena", null, "Armstrong", "486-542-6082", 2, null },
                    { new Guid("fcffcdbe-b1bc-2289-0b78-2624b2260532"), "082 Amely Keys, Garrettview, Pakistan", "Hilbert99@yahoo.com", "Camilla", null, "Schmidt", "956.984.2495", 3, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_TeamId",
                table: "Users",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_UserId",
                table: "Clients",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Teams_TeamId",
                table: "Users",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Teams_TeamId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Users_TeamId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("001cf7d5-59b0-1b3a-262c-9930a1c4a466"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06de0b0d-fc2d-8228-a731-b7f5fbd808ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08f17907-6bd2-e3b4-9388-2661ece83c73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ad6624a-e828-da44-7e05-1ba105ad38ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e9d38ea-563c-c044-609f-7351a1e6efd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0eda7eae-9fd8-9578-6637-617213e85222"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f0d5217-46ad-ba8e-744d-d7100b2b20f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f165cf1-3ee9-7aea-660d-a081dfc931d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f6d1994-ccf3-4606-f67c-ee71855a65c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1057629d-e8ed-9d0a-4826-0cf687b88e50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1190ffa7-e7f5-4a5b-8e53-af51ae4c99c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1430f0f6-2aef-67b8-95a7-a41fc5b93ccf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("169fef91-ecb3-8a67-4e3f-4f4e859ef428"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("172065ed-d22d-b54d-49d7-dea6175f6663"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17648e9d-0a67-018c-20b5-5b95b218676c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18412851-8065-3758-06f3-096c47be2063"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18ec83b6-770c-604d-4406-d5014d6960dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19678322-c9a9-3aea-d087-57f49e4d1d2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d2fb5d9-a7eb-0d1f-6ae7-d04c5276aab3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e15f6f6-736b-77fa-d453-361c137f971f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20462d61-ea6f-9621-05c6-c912a410de6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20e945a0-11f9-a3f9-bc15-0f6b9c64302a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2186bf7c-adfd-f953-328a-06b15388143e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21e79ebc-15d9-533b-9078-d599c13d2d9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("248fb1f2-f1fc-59bb-964e-ecae4f46a57c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("262c214d-3fbe-3970-28f9-4ff6ff64ca7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26fcfca7-6c6a-e507-39fa-4524df083e6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("287711bb-a6ce-e289-d1df-2bfd4f453694"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("292f1684-36c1-2068-c015-6f79dc6e1208"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29901472-626e-c015-676c-429f1be96a43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a2595a0-5601-b1de-6005-c55be17bac33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2cfa1e66-cc87-a06b-5945-0ebfbd353c1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30273695-92ff-66ad-f25c-846eda48b6ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30caff52-a543-4e62-52c0-c65b22bf4494"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31221009-5f96-0f80-49a0-ef1191dae7a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31c0ae67-e58d-5790-9143-0ced504ed9d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33769b64-51bf-d764-0706-05db0305c645"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("342fd0d1-60de-af2b-2d7d-f1fcafccccca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("359c3d64-b261-a0fa-6af4-8d5549f752c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3658b3e9-3146-14df-4cbd-aef9f99011cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36dec671-b191-20eb-5f47-4f78de593d0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("372ad942-7a4f-4e6d-3029-7b27cd8a5368"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38688037-4360-b563-c11e-02fa52836357"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("388ba4d5-ed7b-b003-63c3-333c9df51d77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3932528f-6e05-f7a5-04ff-2b568f613669"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39aba7d9-0fc7-ff83-6bd6-d63abc974940"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ae948ea-6b66-55c8-9c8f-4e938e888740"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b7683bf-15c6-de39-fe7b-501036af0eb0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c97d86f-80c3-5f49-91c5-2e02cbc8c67b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e40238a-c97f-7d93-cf78-324990d1ad26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3fbe5dee-2463-819d-a699-0d6151422839"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("400562e6-4540-ff08-10a8-e9435b0a8b2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42368ef6-5ea0-bd19-c104-40eb33baaddf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("427f315e-4e4c-65c6-33f7-8bc823528c64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4369cb58-d228-4b06-bb1e-0f1d1cadd1e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44232d76-5f05-58b8-1880-c707df381386"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44b22a0d-3619-d347-98c5-de4f7be80484"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("454983da-48c3-cd1d-d223-5039f59be3c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49d80853-691e-ec9b-3a85-d2a85a97f2c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a13eeea-41b3-0bd9-bb0e-d4e5dbeed28d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ade8b68-866b-6398-bbd9-22129e0598bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51961631-bf81-fba2-45af-ae31ab672554"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52cfbafc-af50-4da6-c276-b1bc71823fed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55b7c60f-6f04-7c86-5309-7f937faacf30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57bc4634-9c16-de0b-d25d-74f0a77d9fec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57caf2ce-4713-1fb6-48ad-f7906816a121"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58602e48-e6b7-c9c3-266c-010ca36ca2b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5941a0fe-b530-d1cf-fc9d-29ec93c7ea7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b46f9c5-78ec-0d95-2a4e-f0182f24e1f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5dcd118e-5391-3dad-0e4c-a1c6a8bf7c83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("610c0250-24c4-bbc7-e5a7-1224b8d4f6d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("625c34a8-4fcd-ac02-f651-c941d3b58221"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("638cd153-26b3-5db3-43da-0a13708b642a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63c53a7d-25fb-57c3-f03d-743153384ddf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66173a32-d8d3-92a5-2134-906fad885de7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("670c1196-8c71-5780-f4da-2bedf6ef23c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67297d5f-972b-f276-05f4-804714cfcece"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("697a95a0-e671-804d-1c00-570efc8c4d6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("697bc8f9-1a84-aaeb-323b-5b63dbd70465"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6991d5af-787a-f09b-506f-c216b9503583"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69a800b9-0011-a1cf-475b-cd2a200d758b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b0dd75a-db2f-121a-4868-7531a90c81a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c24e5bb-894e-37a4-027b-a0d2f56c615d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c6456e1-38a7-6ae1-d746-205742bc847f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6cdf635d-9a1b-72d4-86a3-4e7a4e429e12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6dea2c8c-33ed-b3ae-6b71-7718b7df8b55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7008032c-f119-8fd7-181e-cb0812659c9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("721a05fb-91b5-2d5f-14b6-e1ce7f64fc9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75473389-a83a-c08d-448a-9a531a36b018"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75708e67-3888-146e-f48c-5cfa93a74456"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77139307-05d8-7e72-9ab4-fc1bf12073be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7844e230-9930-cfdd-d6b1-989863187def"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79675bb9-e3c8-cd20-b88f-7d7b93baac4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a982cad-06d5-6a0f-c189-95fc9a1a76de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bb9307d-f8e1-c123-2475-94f6f59f31be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7db5fa8e-807a-eea6-5ea6-99cc41e4d70f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fc2116a-7f4a-e5fd-1bb0-cc61204c3e15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("805c512d-678f-5be2-6846-f2ce7c1d7625"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80b22c5a-168e-622a-6c24-75a0c12606d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("810e2244-8df8-f249-a151-c7e0195b318c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("815dca5f-11d6-224d-3d58-4bfb231745a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8339fdd2-9b03-0345-878d-129746d05418"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("839177b0-11c6-5298-e9b2-f8c2cecc2859"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8410350e-76ce-ccae-8610-b884117b2291"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("842dccc7-93bb-60e4-dbda-ce03864c30dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84502662-d1ef-49aa-ef6c-d54d6bd9c6f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84a1a761-8bf6-eed1-90a4-38464ae410eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("857f8131-92e6-6c0c-c55f-3684403128d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("857fae46-84b6-4bd3-e409-9676f2b0fd73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86aa8cde-d480-b3e3-1207-7501eed414db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86e28ff1-994e-9127-c179-d7bcf1cf1021"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("879eacfc-f487-b411-0aa0-3b01a22b187d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8859d867-746c-ed78-742e-75c1b39fc45c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8999c31e-6dcd-ebc0-72f3-9eb0aabacb14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("966756ef-6eb5-106d-9b5d-b5630f6c4448"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("982f3f95-8da0-1e27-68bb-9200ba2995a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9954dd74-dd5e-3561-3bad-d6b2917a050b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d149fc8-94d7-3265-a816-9b6fd33da63b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9dc30acf-2649-9822-eb75-9f5a3ebf5657"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0413dd5-f04b-bd10-6b38-f22fe42e8ab6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a067d22b-7eac-20c3-ee80-916fad5ec69f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3310193-ee09-dcea-f518-8415559f6302"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a421b820-6314-79c4-0839-cbfc6a891de0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a541b00e-4cb3-4869-0925-b788e39b61c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5cdb376-49c8-eb32-e6c2-e280a9a7b014"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a61409c0-ddcf-0768-2658-119aed428f49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a64f55aa-89e4-88c5-2ccb-e40a669cc013"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6ad2da5-056a-d1eb-eaeb-ac5572c64cf1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaf3d1f6-67cc-a902-a151-af4f66e8389f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac01749e-ea94-dd97-7d42-cd879fd945fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac558501-fafe-ccfc-52bd-03122382c12a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae2330be-3194-44e2-f567-b380bec0594f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b03cfd40-7f52-3ca9-fc50-80f1d40ab726"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1ef9173-0e85-4adc-700d-eb7dbc240d98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2220394-288e-edaa-ea22-0c6994da76b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b25d20a9-383c-79ef-46bf-c89e5a02a61f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3a499b7-0dfb-baa3-ab63-a27007794a48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b50b763f-c5a5-b97c-1e80-e275fd9c06f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5b9ac87-ea81-a986-263c-bc6df3b189d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b68d4642-e360-c990-2313-f0d56421373b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6ae1c98-a1d2-774a-7fa9-ad9ab596ce5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8d5b325-dbb4-7387-e837-c4390a97f45d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8fa74bc-6271-89f6-063d-3723d170fbd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b936cb2e-24f5-d22e-30c0-7b97fcbb1be7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bab251ed-a5ca-3db2-9c7f-615588080945"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb0faffb-14a0-6db7-de32-0106354effac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb4d98ec-f4b4-37e0-2a3a-a14d7303f120"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bbc2d455-1965-c9c0-010b-aa8404e17a8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc20b242-4745-4a08-bd8c-cdece4f41d23"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be3ad6aa-fcf0-2a3b-8dec-f6db05fa394f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf351203-2e27-be84-6657-ab45e54ef994"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfb07723-14db-f5ba-c54e-d80adfd0bfda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c02f1d4b-79ac-c8d3-11b4-8d206ba3e01c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0a9fc0f-bb6e-b2f4-2b46-bebd6356318b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c28c62e9-b428-09cf-b60b-9ddb08154b91"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3a7f1c4-d39c-e25a-f308-c81612cc58cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3cc743c-46ac-c7b7-f671-be361def3e65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7b932a8-59ad-9392-be49-4228b0b13ae1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c825ca37-892b-3c8c-a3de-a46af0b3dd1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8d0291b-c666-2481-bb07-86cc00de99d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca1a1485-d879-6f3f-860c-76b6af81131d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca89163e-21d4-4510-7c6a-961ddf210c12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb78de15-407d-62de-cadd-81e8cb70ca9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cbb774e1-e565-3319-8f97-11dacf5c5fd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf3f7034-6294-ea0a-6974-1ba447ba33f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d16dd78b-0a8e-6295-b19f-8d7d9b5e225d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d26bb6a1-4921-e9f9-57af-ddb3c18b87c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d72fa178-f2db-7f82-9de7-45f883632664"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8259929-6624-5cc3-33c0-256195fd0bad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d93fa46d-55d9-8cac-98e5-d5ffe6d26bd9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dad19072-7a5d-cf63-7af5-04b7c1048930"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db9c8ced-ffe1-937f-1622-9221d2d68fc7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbda2bc2-10f7-e92c-46d8-62426000cb4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd68b929-c181-6dd4-f849-17e7b73cadb1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd893958-9b36-89fc-1c54-837e435ae8a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de529483-4eec-eda4-de49-b25f78394339"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e314d593-bc80-1509-07fe-a8e41c3a9aa4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e390ef18-11e1-34a1-62d2-e62a0b688808"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e42e8e32-57b6-ad35-ee64-d53a84ddda62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e53ff1a4-8367-8270-109a-4de0821b6ac0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5ed11c4-b795-fc5b-aee8-48780b360371"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e73e9407-e734-a0e2-444e-cf3f7fadadfa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8c911d2-f3c4-cc68-d6c5-f9e339c7efc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e936ad85-8afa-61c7-de0d-61eaa229d839"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9e7929a-8a59-2817-ca1c-9383ab0fd3ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea5ea0ba-ca99-953a-09dc-944b394b0e83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eaf7d344-cb37-64e1-77b7-5313ae2f38cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ecc07b06-0257-874b-8487-fa5be3040760"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee2da4ec-09a7-6ed8-1b94-676a189906aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f016dfe9-0aa9-1a3a-c90b-02d029dd528b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f07d3212-3571-960a-1fe7-b5173889ddaf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2023bcd-6252-ad43-9174-02332c31b8ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4831008-3c08-b7cf-0f9e-aae807affaff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f63e33f9-7f5d-7f52-fe05-9ae26c0f206c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc9cae13-76f9-5e0b-16ed-931aa60709e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fcffcdbe-b1bc-2289-0b78-2624b2260532"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IdentityUserId", "LastName", "Role" },
                values: new object[,]
                {
                    { new Guid("0058a4c5-fa63-f163-1074-5a56e68d92e7"), "Aisha.Lemke71@hotmail.com", "Millie", null, "Kuhic", 2 },
                    { new Guid("0092bb68-29ba-a095-2f44-758496282394"), "Noemi.Weber62@hotmail.com", "Jerry", null, "Koch", 3 },
                    { new Guid("01750712-d4ee-db14-6bc6-2fce79cc8bdb"), "Dora_Heller77@yahoo.com", "Lydia", null, "Jast", 3 },
                    { new Guid("067e8687-b733-ebae-5ed1-1df2a6a68416"), "Adrian_Beer@yahoo.com", "Maxine", null, "Donnelly", 2 },
                    { new Guid("06b0a0d1-4081-ca08-c383-3f7cd1be02e0"), "Arnulfo_Spencer60@hotmail.com", "Kristy", null, "Ziemann", 3 },
                    { new Guid("07392842-2793-6bde-56f9-03654111fe7c"), "Dandre.Langworth49@gmail.com", "Marianna", null, "Schultz", 2 },
                    { new Guid("07639d99-f179-d208-6bb4-e393882661ec"), "Alisa.Abbott@gmail.com", "Malika", null, "Bauch", 2 },
                    { new Guid("07bee05f-1393-d877-0572-7e9ab4fc1bf1"), "Kirstin.Gaylord@hotmail.com", "Afton", null, "Toy", 2 },
                    { new Guid("07d76451-0506-03db-05c6-458330a6cfc7"), "Hazle_Ryan12@hotmail.com", "Minnie", null, "Weimann", 3 },
                    { new Guid("0bd67f61-55e6-6855-6a82-1e87d025ad8d"), "Delores_Weber@hotmail.com", "Leola", null, "Dietrich", 1 },
                    { new Guid("0c3cdf89-7ab6-7093-d4f8-c08fc63aac08"), "Dan.Zemlak@yahoo.com", "Alta", null, "Oberbrunner", 3 },
                    { new Guid("0c48eb8b-e729-337e-86ac-7de68f91f30b"), "Scarlett.Bergnaum36@gmail.com", "Joannie", null, "Rodriguez", 3 },
                    { new Guid("0d565335-64b6-8607-67c4-8f189a8efab5"), "Taurean31@yahoo.com", "Lenna", null, "Collier", 2 },
                    { new Guid("0d704adc-7deb-24bc-0d98-bfd1e72201fc"), "Desmond97@gmail.com", "Reina", null, "Luettgen", 1 },
                    { new Guid("0f494083-52e4-b03c-edb5-8e331bae54c5"), "Lula.Morissette10@gmail.com", "Adan", null, "Gerlach", 3 },
                    { new Guid("104ad276-b46c-a98f-aa2b-50e3d1a573e8"), "Dennis_Cartwright@hotmail.com", "Kyler", null, "VonRueden", 1 },
                    { new Guid("105644a7-3c5b-734c-8816-a5f7475a0c49"), "Porter_Bode44@gmail.com", "Alene", null, "Denesik", 2 },
                    { new Guid("10827083-4d9a-82e0-1b6a-c0d0ccfdba9e"), "Kianna21@gmail.com", "Zula", null, "Tillman", 3 },
                    { new Guid("13496b76-4138-1223-583b-c42f04fae301"), "Rowland90@yahoo.com", "Marcelo", null, "Funk", 2 },
                    { new Guid("165cc49f-2eb5-1090-41ae-58318ec217e8"), "Jessica_Hickle@yahoo.com", "Chaim", null, "DuBuque", 1 },
                    { new Guid("165e0b76-93ed-a61a-0709-e6173f8f7b69"), "Adrienne25@gmail.com", "Harvey", null, "Thiel", 3 },
                    { new Guid("16a83265-6f9b-3dd3-a63b-dc1d67c9e0ec"), "Riley81@yahoo.com", "Gabriella", null, "Davis", 3 },
                    { new Guid("16bf3988-3f7b-3fda-a6c1-cf93c4dd93d0"), "Christian.Stark50@hotmail.com", "Thad", null, "Bogan", 1 },
                    { new Guid("172f4c3f-ef46-e342-c4fe-bc71992dbd69"), "Kylie.Haley65@yahoo.com", "Flo", null, "Boyer", 2 },
                    { new Guid("17577b7b-af78-91d5-697a-789bf0506fc2"), "Sarina.Klein84@yahoo.com", "Emmie", null, "Dibbert", 1 },
                    { new Guid("180a41a7-9276-d62f-acbc-41757f2f76e3"), "Queenie.Vandervort@yahoo.com", "Jazmyn", null, "Cremin", 2 },
                    { new Guid("197439f4-2ef6-28c6-858d-3a9553adc808"), "Katelyn.Morissette@hotmail.com", "Judah", null, "Rutherford", 2 },
                    { new Guid("1d0a58e9-9c16-e349-f273-db81440d2d59"), "Art_Tillman@yahoo.com", "Jade", null, "Spencer", 2 },
                    { new Guid("1d48c345-d2cd-5023-39f5-9be3c0298ab2"), "Cassie.Klein90@hotmail.com", "Linda", null, "Erdman", 1 },
                    { new Guid("204a67ac-9362-7e51-3ebf-88678e707588"), "Rolando_Barrows@hotmail.com", "Ron", null, "Sawayn", 1 },
                    { new Guid("2061ccb0-3e4c-bc15-14b6-2f81ffe1e665"), "Filiberto_Berge@gmail.com", "Abbigail", null, "Armstrong", 2 },
                    { new Guid("20866f32-9e62-296f-f498-5c15cb314fb9"), "Cyril.Wilderman88@gmail.com", "Dario", null, "Upton", 3 },
                    { new Guid("20b72de6-5ab6-af91-93fe-296e37f6e539"), "Tomasa19@gmail.com", "Reagan", null, "Halvorson", 3 },
                    { new Guid("2210097c-9631-805f-0f49-a0ef1191dae7"), "Sterling85@hotmail.com", "Holden", null, "Walker", 3 },
                    { new Guid("2240f80c-fe6f-9ae3-a16f-2c2be4035ba8"), "Kayden_Ritchie10@yahoo.com", "Abel", null, "Cronin", 1 },
                    { new Guid("2573aab7-d4ae-2632-e632-87b47a9d79f1"), "Carmella.Hayes@gmail.com", "Oswald", null, "Becker", 1 },
                    { new Guid("29525f10-2599-24d8-66c3-5c33c0256195"), "Dashawn_Leannon@yahoo.com", "Simeon", null, "Bogan", 1 },
                    { new Guid("29dd5889-bbb8-223b-c1b6-694638d5da36"), "Elwyn_Stroman@hotmail.com", "Marta", null, "Emard", 2 },
                    { new Guid("2a30649c-808c-0ae3-341f-9f4f1397c0b6"), "Edwina_Schaefer@hotmail.com", "Jaida", null, "Goyette", 2 },
                    { new Guid("2bff04f7-8f56-3661-69d8-3402a5952b9f"), "Rosalee.Wunsch@hotmail.com", "Marjory", null, "Sauer", 3 },
                    { new Guid("2ceefe3b-063b-9189-0bcc-da39698c66a6"), "Jalyn.Rice@yahoo.com", "Silas", null, "Walter", 1 },
                    { new Guid("2efe0dbb-08d3-2e7c-c277-d6b267a146ae"), "Pink.Kovacek85@hotmail.com", "Amari", null, "Hessel", 3 },
                    { new Guid("2f46e850-9242-0ced-7c1b-5b83aeea87da"), "Toni32@gmail.com", "Winnifred", null, "Gottlieb", 1 },
                    { new Guid("304e6d7a-7b29-cd27-8a53-687bd53aec00"), "Nyasia98@gmail.com", "Josiane", null, "Kuhn", 2 },
                    { new Guid("32e5a87b-56d9-1df9-9a1d-1994196d0ff3"), "Emie.Carter@hotmail.com", "Alisa", null, "Zboncak", 1 },
                    { new Guid("338528d3-9af4-c671-de36-91b1eb205f47"), "Alexis.McDermott20@gmail.com", "Emilie", null, "Greenfelder", 1 },
                    { new Guid("3485d116-293b-23c8-bf83-763bc61539de"), "Lola.Schuster@hotmail.com", "Torrey", null, "Stoltenberg", 2 },
                    { new Guid("367b96c2-b6d2-f574-4a87-855d27f678da"), "Bradley78@yahoo.com", "Oliver", null, "Tremblay", 1 },
                    { new Guid("376ca99a-712c-032d-643d-9c3561b2faa0"), "Dexter_Heidenreich@hotmail.com", "Serenity", null, "Nienow", 2 },
                    { new Guid("38eb94ec-4cb2-926e-e2c3-9a590ba1a5d4"), "Queen.Hills7@gmail.com", "Raul", null, "Gibson", 2 },
                    { new Guid("3a1ce4a8-a49a-c16a-7b34-c9f6fe7f7d4e"), "Stephan74@hotmail.com", "Althea", null, "King", 2 },
                    { new Guid("3e5a9f75-56bf-e357-cb52-67d4e9ee12d1"), "Brennan_Wintheiser@yahoo.com", "Nathaniel", null, "Kohler", 1 },
                    { new Guid("40089bf2-16c3-56a2-a5f7-df4216bc74fa"), "Amie22@hotmail.com", "Duncan", null, "Marquardt", 1 },
                    { new Guid("403700b3-8af5-87d2-032b-38846c3ddf2e"), "Verda36@gmail.com", "Reynold", null, "Feeney", 1 },
                    { new Guid("40e8226d-cc00-e122-f776-ad5678902be5"), "Ashley_Pfannerstill95@hotmail.com", "Julia", null, "Hoppe", 2 },
                    { new Guid("40f349d9-54ae-6df6-9a5f-b10366f176ae"), "Keira.Ortiz27@gmail.com", "Melyna", null, "Bradtke", 3 },
                    { new Guid("42240cbc-34b4-6c50-b779-1d3d40230273"), "Colleen_Bartell70@gmail.com", "Daren", null, "Connelly", 2 },
                    { new Guid("4331a6f8-2879-1ed7-dd37-72d795140a70"), "Noble_McLaughlin@hotmail.com", "Ocie", null, "Kunde", 2 },
                    { new Guid("46f8f28c-9d4f-5dd3-5605-6f1c2de7d8a8"), "Terence87@gmail.com", "Tremayne", null, "Schamberger", 3 },
                    { new Guid("47d11ea7-8197-cd61-ad4c-701091dd62d6"), "Kade51@gmail.com", "Terence", null, "Thompson", 3 },
                    { new Guid("48121adb-7568-a931-0c81-a9e1f40283d3"), "Jacey_OKeefe@gmail.com", "Anabelle", null, "Hegmann", 3 },
                    { new Guid("499615e1-f7c6-c110-eb41-ebb044c412d8"), "Cyril.Abernathy44@hotmail.com", "Coty", null, "Lubowitz", 3 },
                    { new Guid("4a4638a4-10e4-f7eb-ba5f-0837cc75bf40"), "Roxane.Ondricka64@yahoo.com", "Mabel", null, "McDermott", 1 },
                    { new Guid("4fac5e66-1450-43f7-b94a-7bb9aa729115"), "Ruthe_Leuschke@yahoo.com", "Curt", null, "Hoeger", 2 },
                    { new Guid("520d8394-7813-a31d-6762-f3a3b65801f6"), "Isai67@hotmail.com", "Donny", null, "Wyman", 1 },
                    { new Guid("565edeb1-061a-e964-dbb2-dc60bed4adf6"), "Ana.Grant@yahoo.com", "Vincent", null, "Cremin", 3 },
                    { new Guid("5775dc78-8902-7878-87c1-f3e33fa3fe93"), "Madisen.Davis@hotmail.com", "Yadira", null, "Kuvalis", 3 },
                    { new Guid("585c493d-4335-6b3c-e1ed-5744d3de93d5"), "Lee.Gottlieb@yahoo.com", "Roma", null, "MacGyver", 2 },
                    { new Guid("59c723ef-4006-d85b-b391-4f5e5b8582af"), "Linda_Welch63@hotmail.com", "Jo", null, "Larkin", 3 },
                    { new Guid("5a2a9876-2a2d-2642-f974-bbde29357df7"), "Constance45@gmail.com", "Judy", null, "Bayer", 1 },
                    { new Guid("5a8b8d55-b22c-8e80-162a-626c2475a0c1"), "Elmer.Schiller@hotmail.com", "Malcolm", null, "Klocko", 3 },
                    { new Guid("5b47a1cf-2acd-0d20-758b-62e11c941b28"), "Damion_Frami91@hotmail.com", "Velma", null, "Mohr", 1 },
                    { new Guid("5bc50560-7be1-33ac-4d2a-63b4f7501bb7"), "Crawford96@hotmail.com", "Filomena", null, "Kulas", 1 },
                    { new Guid("5bd45ad1-30bc-2eeb-107d-52650706c3d3"), "Cayla16@hotmail.com", "Candelario", null, "O'Hara", 3 },
                    { new Guid("5c52b8de-f4ea-e7e5-702e-f0f1d195d77d"), "Bernadine.Weber45@hotmail.com", "Arjun", null, "Quigley", 3 },
                    { new Guid("5d15e115-3b81-6dec-675c-e0c61658d76e"), "Jude2@hotmail.com", "Deven", null, "Spencer", 1 },
                    { new Guid("5db326b3-da43-130a-708b-642ae146287c"), "Julianne72@yahoo.com", "Roger", null, "Wiza", 3 },
                    { new Guid("665f17a6-7963-dd61-4e38-55c593ef0f6a"), "Cecelia.Jerde@hotmail.com", "Darrin", null, "Bode", 3 },
                    { new Guid("6a403057-4bad-b27e-582e-46d540bdd2ec"), "Joelle.Green@hotmail.com", "Rylan", null, "Kovacek", 2 },
                    { new Guid("6a6fdb59-5712-8cdb-3660-d7738e68ed65"), "Brannon_Schultz69@gmail.com", "Martin", null, "Ullrich", 1 },
                    { new Guid("6bbc9805-8314-0b7b-7538-7b06bef52361"), "Verdie_VonRueden53@yahoo.com", "Wilber", null, "Kreiger", 1 },
                    { new Guid("6edc796f-0812-fb59-6353-734b10c183c9"), "Lonie.Mills@yahoo.com", "Orlo", null, "Runolfsdottir", 1 },
                    { new Guid("6f6320be-0061-6073-25e2-835a022927ab"), "Devan_Lynch25@yahoo.com", "Walter", null, "Rolfson", 3 },
                    { new Guid("7166cc5e-f488-0394-22b2-8e28aaedea22"), "Garrett.Abbott@hotmail.com", "Filomena", null, "Beatty", 3 },
                    { new Guid("716bb3ae-1877-dfb7-8b55-fcd54a9baa7a"), "Rupert25@gmail.com", "Cynthia", null, "Dach", 2 },
                    { new Guid("71a565f3-4d46-5c30-2286-dfefc576a688"), "Perry96@gmail.com", "Lysanne", null, "Dicki", 2 },
                    { new Guid("7387dbb4-37e8-39c4-0a97-f45d593e9b08"), "Parker_Keeling@gmail.com", "Magali", null, "Lubowitz", 3 },
                    { new Guid("7469ea0a-a41b-ba47-33f0-9cd9abc2eec1"), "Carolyn16@yahoo.com", "Natasha", null, "Walsh", 3 },
                    { new Guid("75573e0f-66fc-301a-3f78-040b11078f6a"), "Raheem.Runte@gmail.com", "Christopher", null, "Pouros", 3 },
                    { new Guid("76202017-9833-b87b-50b6-0d688bde4a6b"), "Christiana37@hotmail.com", "Eduardo", null, "Reilly", 3 },
                    { new Guid("765e58fd-d7d2-cede-12a4-309dcaa25bcc"), "Arnoldo99@gmail.com", "Raphaelle", null, "Littel", 1 },
                    { new Guid("77eb78e0-3f3c-52ed-3afe-e9b9e156f729"), "Roy58@hotmail.com", "Heloise", null, "Auer", 2 },
                    { new Guid("7890533b-99d5-3dc1-2d9b-b56ebd0fbfb2"), "Teagan.Heaney@hotmail.com", "Shaylee", null, "Weissnat", 1 },
                    { new Guid("7964d853-6bab-4f45-c068-a64b9de6d1cf"), "Betty55@yahoo.com", "Montana", null, "Kutch", 1 },
                    { new Guid("7b47f4ce-e98a-204b-d71b-3c1aa97a5434"), "Letitia75@hotmail.com", "Luigi", null, "Crist", 2 },
                    { new Guid("7c5adb77-134e-09c0-14a6-cfdd68072658"), "Jamal_Grimes57@gmail.com", "Marcos", null, "Jones", 1 },
                    { new Guid("7c660504-9295-3c2f-9b20-bec9c4a8ce38"), "Franco_Reilly55@hotmail.com", "Esteban", null, "Kessler", 3 },
                    { new Guid("7d0efd96-d147-7ef0-17d5-03cdcdc2738f"), "Haley.Reichel73@gmail.com", "Franco", null, "Wiegand", 3 },
                    { new Guid("7f64f29f-40f0-d75c-970f-6e32b43b6fd9"), "Wilford.Lakin99@hotmail.com", "Kody", null, "Littel", 3 },
                    { new Guid("8016d4d1-b242-bc20-4547-084abd8ccdec"), "Marina_Barrows@yahoo.com", "Isaac", null, "Monahan", 3 },
                    { new Guid("84e3a52b-395c-c898-2e55-f7d9fe0033a7"), "Abel59@hotmail.com", "Sarai", null, "Krajcik", 3 },
                    { new Guid("8672d49a-4ea3-4e7a-429e-120bc35897c2"), "Jordyn13@yahoo.com", "Trenton", null, "McLaughlin", 2 },
                    { new Guid("873d728b-cbbf-74d2-dd54-995edd61353b"), "Laney.Kilback@yahoo.com", "Merritt", null, "Ebert", 2 },
                    { new Guid("874b0257-8784-5bfa-e304-0760a65de71a"), "Leonel_Lockman75@gmail.com", "Davin", null, "Fritsch", 2 },
                    { new Guid("8a32f953-b106-8853-143e-fa9cda00db61"), "Mortimer.Rice41@gmail.com", "Isai", null, "Fritsch", 3 },
                    { new Guid("8b0b1cf3-4974-08b8-1083-f4083ccfb70f"), "Kurt55@gmail.com", "Albertha", null, "Carter", 1 },
                    { new Guid("8ba4d549-7b38-03ed-b063-c3333c9df51d"), "Paolo_Koelpin64@hotmail.com", "Harmony", null, "Beier", 1 },
                    { new Guid("8ca871ba-dcf3-171d-8d61-62acb5b5bc21"), "Osvaldo.Cassin@yahoo.com", "Franz", null, "Friesen", 2 },
                    { new Guid("8dda0845-b78d-e7fe-69c9-85dfc0e43150"), "Monserrat13@yahoo.com", "Bobbie", null, "Torphy", 1 },
                    { new Guid("91c8655a-3430-02fd-6646-1f59aaf5289f"), "Destany.Jaskolski@yahoo.com", "Dudley", null, "Weissnat", 2 },
                    { new Guid("92db33b6-61bf-6ca3-dc30-aad648d33795"), "Abdullah.Ferry@hotmail.com", "Otha", null, "Anderson", 1 },
                    { new Guid("92e6857f-6c0c-5fc5-3684-403128d6c266"), "Leland_Muller84@yahoo.com", "Bo", null, "Fritsch", 3 },
                    { new Guid("9301b844-ecde-864f-abde-eb9e4d845807"), "Aurelie_Funk@yahoo.com", "Kallie", null, "Blanda", 2 },
                    { new Guid("937b7d8f-acba-684d-bd3c-2d5596c27c04"), "Leonora_Runte50@yahoo.com", "Elaina", null, "Jacobson", 1 },
                    { new Guid("948c315b-0f72-a0ba-cb59-2a602ad4b975"), "America67@gmail.com", "Christelle", null, "Mann", 2 },
                    { new Guid("95153d21-9ea2-c0cb-a6a8-3bafe6068cd2"), "Ken13@hotmail.com", "Pattie", null, "Williamson", 3 },
                    { new Guid("9589c16a-9afc-761a-de49-155a3e92c1d4"), "Lemuel.Kiehn74@gmail.com", "Magali", null, "Kunde", 2 },
                    { new Guid("968bd376-79bc-1120-ff3e-b4d27477dda7"), "Alfreda.Lockman@hotmail.com", "Keshawn", null, "O'Kon", 2 },
                    { new Guid("9a824079-4a18-d662-0a28-e844da7e051b"), "Unique.McLaughlin@yahoo.com", "Lemuel", null, "Senger", 1 },
                    { new Guid("9a8ffcdc-ec64-6948-2bb3-705470cb8a1c"), "Mellie_Walsh91@hotmail.com", "Chanelle", null, "Weimann", 3 },
                    { new Guid("9b2f20ee-3513-bab5-b6d5-c8c455d37f83"), "Crystel81@yahoo.com", "Eloy", null, "McDermott", 3 },
                    { new Guid("9b36dd89-89fc-541c-837e-435ae8a5f64e"), "Marielle54@gmail.com", "Antonietta", null, "Feeney", 3 },
                    { new Guid("9eb45a6e-019a-278f-01f6-d93a212c258d"), "Cassidy.Hills65@gmail.com", "Mallory", null, "Shields", 2 },
                    { new Guid("9ec01e5e-9851-c366-d519-b4ddf15c160f"), "Emiliano60@gmail.com", "Bart", null, "Bogisich", 3 },
                    { new Guid("a02fada4-f38a-c7fe-b1b6-acc30fda295e"), "Nathanael_Volkman40@hotmail.com", "Belle", null, "Doyle", 1 },
                    { new Guid("a11a8931-36f9-92a2-7271-4af2ee5dbe3f"), "Bartholome.Blanda33@yahoo.com", "Ezekiel", null, "Rippin", 2 },
                    { new Guid("a12cd393-04b0-186a-afe9-dbf68d8f2254"), "Francisco_Lang@yahoo.com", "Jacinthe", null, "Denesik", 3 },
                    { new Guid("a13d7d5d-8ee1-271c-425e-b0512602d13d"), "Monique94@yahoo.com", "Anastacio", null, "Fisher", 2 },
                    { new Guid("a20d9352-650f-6908-0019-371e2edbaae3"), "Jonatan_Kilback80@yahoo.com", "Nelle", null, "Corwin", 1 },
                    { new Guid("a3582d66-ea36-9d38-0e3c-5644c0609f73"), "Mozell.Torp56@yahoo.com", "Forest", null, "Carroll", 1 },
                    { new Guid("a614ad4e-051f-c380-b342-468db660e390"), "Ibrahim.Renner@yahoo.com", "Vincenzo", null, "Corwin", 2 },
                    { new Guid("b1aa5f7d-57a4-3593-9a0f-299740c7c3d2"), "Verner.Grant@hotmail.com", "Pierre", null, "Kihn", 2 },
                    { new Guid("b1f36dbc-d289-bd8a-f47f-d9b1a5aa4abf"), "Wendy_Parker@yahoo.com", "Uriah", null, "Abshire", 2 },
                    { new Guid("b361bc3e-aec0-56f2-6e21-52ffca3043a5"), "Edmond_Romaguera14@yahoo.com", "Earline", null, "Watsica", 2 },
                    { new Guid("b367f544-be80-59c0-4f69-29f8d52b0f7d"), "Orlo_Cremin@yahoo.com", "Bulah", null, "Kautzer", 3 },
                    { new Guid("b3e952a5-3658-3146-df14-4cbdaef9f990"), "Emmanuelle_Hodkiewicz9@yahoo.com", "Hudson", null, "Senger", 3 },
                    { new Guid("b405dd95-3766-66b4-c568-96b9db3fd956"), "Kraig_Hirthe15@gmail.com", "Merle", null, "Cronin", 1 },
                    { new Guid("b5910a8a-853f-9a4d-e8e9-6baa51d0214d"), "Myriam51@yahoo.com", "Rossie", null, "Wyman", 3 },
                    { new Guid("b59b08e3-fdeb-db24-56be-b0c9ea21c09d"), "Reilly96@gmail.com", "Dominic", null, "Turner", 2 },
                    { new Guid("b5d341c9-2182-fe0a-be45-1b38fa33697e"), "Letha_Hermiston2@hotmail.com", "Wade", null, "Hansen", 3 },
                    { new Guid("b6a6b15c-7a36-a79a-87ae-7eda0ed89f78"), "Odell.Marvin88@yahoo.com", "Guiseppe", null, "Kub", 1 },
                    { new Guid("b727c608-0aff-4a4c-d1a5-bc10e41e4d21"), "Lera.Hermann61@hotmail.com", "Shawna", null, "McLaughlin", 1 },
                    { new Guid("b8312c33-f1ae-bd16-1431-3b4b516d4386"), "Lydia_Schiller50@gmail.com", "Angelita", null, "Ruecker", 1 },
                    { new Guid("b92f47e2-f508-0df5-8171-9adc10a4cd3b"), "Shea_Keebler18@yahoo.com", "Juston", null, "Schamberger", 3 },
                    { new Guid("bce5aef2-aa63-281d-f148-7ad63aba47ba"), "Logan24@hotmail.com", "Kaley", null, "Blick", 2 },
                    { new Guid("be11df75-fe77-41a0-5930-b5cfd1fc9d29"), "Joshua3@yahoo.com", "Estelle", null, "Kuvalis", 2 },
                    { new Guid("bff2fd2a-d21d-66f5-63cd-ba1ec69cd4da"), "Jermaine96@gmail.com", "Mckenzie", null, "Denesik", 2 },
                    { new Guid("c2d455f4-65bb-c019-c901-0baa8404e17a"), "Lupe_OConnell@yahoo.com", "Nestor", null, "Schowalter", 3 },
                    { new Guid("c2eba90a-53ec-9dcf-2d68-080be78057ed"), "Maia45@hotmail.com", "Arden", null, "Schoen", 3 },
                    { new Guid("c55e12eb-5780-f200-9f6a-25f1c4306877"), "Rhianna.DAmore@hotmail.com", "Sally", null, "Raynor", 3 },
                    { new Guid("c5b217bf-5940-134b-3335-ed054e944d07"), "Marcelle20@yahoo.com", "Coleman", null, "Keebler", 3 },
                    { new Guid("c76fbc97-8e5b-3a32-1766-d3d8a5922134"), "Genoveva.Toy59@hotmail.com", "Kurtis", null, "Johnston", 1 },
                    { new Guid("ca64fff6-b77a-a7c0-f27a-5be247be3bcf"), "Deonte_Witting@hotmail.com", "Erik", null, "Gislason", 1 },
                    { new Guid("cb1517bb-e1aa-fa50-af5b-94db961366c2"), "Cristian51@hotmail.com", "Michaela", null, "Rempel", 2 },
                    { new Guid("cbe881dd-ca70-b79d-8a9e-2f2731d4e155"), "Burley26@gmail.com", "Joseph", null, "Gibson", 2 },
                    { new Guid("cbf4ee22-2bb5-91a3-978c-6b407c26d2e7"), "Ollie.Gulgowski8@hotmail.com", "Blanche", null, "Johns", 1 },
                    { new Guid("cd12f6cc-0d1c-d030-bc67-125128411865"), "Cory98@yahoo.com", "Estella", null, "Goodwin", 2 },
                    { new Guid("cdfce242-2c57-99b7-d759-ef7952307894"), "Neal.Lynch@yahoo.com", "Silas", null, "Rempel", 1 },
                    { new Guid("ce365f68-67b2-ed0a-c915-0744220e81f8"), "Darrel5@yahoo.com", "Geovany", null, "Fritsch", 2 },
                    { new Guid("cee419e3-d632-8ac3-cb0f-fca9c06ebbf4"), "Joana_Schaden@yahoo.com", "Hoyt", null, "Prohaska", 1 },
                    { new Guid("d10badc2-e6a4-8d38-f685-baa05eea99ca"), "Reba_Ortiz79@hotmail.com", "Mina", null, "Bergnaum", 1 },
                    { new Guid("d1446a8f-224e-9fa0-6fb7-acd5bb8bdcc1"), "Cleveland64@hotmail.com", "Lauren", null, "McCullough", 1 },
                    { new Guid("d2284369-4b06-1ebb-0f1d-1cadd1e5ef29"), "Stefanie.Trantow@yahoo.com", "Jade", null, "Stoltenberg", 3 },
                    { new Guid("d3473619-c598-4fde-7be8-048497a37150"), "Eva.Kilback10@hotmail.com", "Cheyanne", null, "Lehner", 2 },
                    { new Guid("d477fa73-3653-131c-7f97-1f15ad5646a7"), "Marta.Swaniawski@hotmail.com", "Ansel", null, "Casper", 3 },
                    { new Guid("d731c9df-5f52-7b91-6fdd-6889b3eeab43"), "Bell_Hintz37@gmail.com", "Celia", null, "Hegmann", 2 },
                    { new Guid("d74b871a-a8c7-8d73-fcdb-9bd3d15ef971"), "Dave_Bogan81@gmail.com", "Raymond", null, "King", 1 },
                    { new Guid("d759671d-7bdc-2d0b-e4d4-30ed96110c67"), "Xavier_Schulist80@hotmail.com", "Adah", null, "Ortiz", 1 },
                    { new Guid("d7e441cc-830f-02e5-6d13-0e26d2c96879"), "Marcellus.Schmidt@gmail.com", "Estrella", null, "Hegmann", 1 },
                    { new Guid("d879ca1a-6f3f-0c86-76b6-af81131d66f2"), "Tremayne.Roob@yahoo.com", "Casey", null, "Langworth", 2 },
                    { new Guid("d95846f2-a0a3-d02c-ae24-859849f225eb"), "Adrian_Heathcote@hotmail.com", "Pink", null, "Berge", 1 },
                    { new Guid("d9c16216-20a7-1f0b-a00a-31a0a061e571"), "Quinn.Zboncak@gmail.com", "Kory", null, "Kreiger", 3 },
                    { new Guid("dd5481cd-e02b-8d1e-bb11-7728cea689e2"), "Arden71@hotmail.com", "Louisa", null, "Heller", 3 },
                    { new Guid("dd893817-b7af-33b8-62fd-ba3da3c5833f"), "Ariane_Bartell66@gmail.com", "Keven", null, "Kuhlman", 1 },
                    { new Guid("de608a53-4c46-e96b-8cdd-6b20175487ac"), "Dominic7@yahoo.com", "Quinten", null, "Von", 3 },
                    { new Guid("de6db714-0132-3506-4eff-acb37f89fa90"), "Joesph_Block@yahoo.com", "Charlotte", null, "Waelchi", 3 },
                    { new Guid("dfc4fc00-48d8-54c9-945c-30a667d85988"), "Alexander_Grimes40@hotmail.com", "Hailey", null, "Bauch", 3 },
                    { new Guid("e138a76c-d76a-2046-5742-bc847f30f4f2"), "Karelle_Davis17@hotmail.com", "Kory", null, "Goldner", 3 },
                    { new Guid("e301caa6-1c51-bb74-5e43-b81273afeddb"), "Delphine74@yahoo.com", "Art", null, "Greenfelder", 3 },
                    { new Guid("e528dc5b-f6d3-f3d1-aacc-6702a9a151af"), "Xzavier_White@gmail.com", "Ralph", null, "Dare", 2 },
                    { new Guid("e5bbc724-12a7-b824-d4f6-d4688e99a678"), "Moses66@gmail.com", "Fidel", null, "Windler", 3 },
                    { new Guid("e6dd82a7-1f56-4b88-bf46-2ed1a045e920"), "Sydnee.Block@yahoo.com", "Bianka", null, "Kreiger", 3 },
                    { new Guid("e7f51190-4a5b-538e-af51-ae4c99c7064d"), "Donny32@hotmail.com", "Rollin", null, "Windler", 1 },
                    { new Guid("e948ea49-663a-c86b-559c-8f4e938e8887"), "Mitchell10@yahoo.com", "Seth", null, "Brekke", 1 },
                    { new Guid("eb99142a-7669-c073-c320-a5ef7e12327d"), "Jacey_Herzog@gmail.com", "Britney", null, "Murazik", 1 },
                    { new Guid("edf7dba1-9c8c-e1db-ff7f-9316229221d2"), "Scotty77@hotmail.com", "Consuelo", null, "Hane", 1 },
                    { new Guid("ef7e2bc2-3dd8-4927-bd40-76fb68c0aecd"), "Braxton35@gmail.com", "Anita", null, "Bruen", 3 },
                    { new Guid("f7791c66-c623-a031-7e1c-7381da767bb9"), "Hallie87@gmail.com", "Meredith", null, "Prosacco", 2 },
                    { new Guid("f7ad481f-6890-a116-21e1-f61fdac34ea0"), "Earl_Haag@hotmail.com", "Alf", null, "Kovacek", 2 },
                    { new Guid("f8942f9c-1ffc-a9e8-6323-22d959b960b9"), "Perry_Kuphal@hotmail.com", "Ludie", null, "O'Conner", 1 },
                    { new Guid("fb70d123-8fd1-b6c8-81df-54533aa301e8"), "Koby.Feeney@hotmail.com", "Maryse", null, "Bednar", 3 },
                    { new Guid("fc274454-dd32-1e7a-847e-5ec74840ee73"), "Lorena.Langworth@yahoo.com", "Madisyn", null, "Cole", 2 },
                    { new Guid("fdb0f276-be73-9a06-7710-63cc6ee38122"), "Cathrine38@hotmail.com", "Noe", null, "Brown", 2 },
                    { new Guid("fe3db399-e09a-4069-f7f4-9f7483b01d35"), "Felicity.Beier91@gmail.com", "Russel", null, "Murray", 1 },
                    { new Guid("fe7f527f-9a05-6ce2-0f20-6c86d761619c"), "Don.Hansen75@yahoo.com", "Raheem", null, "Boyer", 1 },
                    { new Guid("feb8d388-d34a-c99c-3c7f-16d4dc2d5415"), "Alexandrine.Aufderhar@hotmail.com", "Evan", null, "Willms", 2 }
                });
        }
    }
}
