INSERT INTO dbo.Address	(AddressId, Street, City, State, ZipCode)
VALUES	('2467842f-e8f1-4318-a8c1-e372448d47ab', '1118 Glenview Lane', 'Eagle Rock', 'CA', '99999'),
		('5b879cc8-88a4-4b29-b8d3-2e6a2648528d', '1126 E Walton Rd.', 'Eagle Rock', 'CA', '99999'),
		('b59e496f-a726-4f8d-a507-c89ce4600a5a', '115 W Norgate St', 'Eagle Rock', 'CA', '99999'),
		('38007ec9-d013-445d-95d6-c654baa10bcf', '13642 Green Valley B', 'Eagle Rock', 'CA', '99999'),
		('997ca9a5-e4bb-4991-bb79-e9d8b86d29bd', '1123 N Barston Ave', 'Eagle Rock', 'CA', '99999'),
		('04b3b756-d7ea-44e9-af53-df0fe0173989', '1110 Avenida Loma Vista', 'Eagle Rock', 'CA', '99999');

INSERT INTO dbo.Student (StudentId, SchoolCode, LastName, FirstName, AddressId)
VALUES	('99400001', '994', 'Abbott', 'Allan', '2467842f-e8f1-4318-a8c1-e372448d47ab'),
		('99400011', '994', 'Abrahamson', 'Arnold', '5b879cc8-88a4-4b29-b8d3-2e6a2648528d'),
		('99400012', '994', 'Abrego', 'Alice', 'b59e496f-a726-4f8d-a507-c89ce4600a5a'),
		('99400013', '994', 'Abrego', 'Ivette', '38007ec9-d013-445d-95d6-c654baa10bcf'),
		('99400014', '994', 'AbuJohn', 'Edgar', '997ca9a5-e4bb-4991-bb79-e9d8b86d29bd'),
		('99400015', '994', 'Aceves', 'Steven', '04b3b756-d7ea-44e9-af53-df0fe0173989');

INSERT INTO dbo.Contact (ContactId, LastName, FirstName, Email, Mobile, AddressId)
VALUES	('fa4380e2-57da-4aa8-844c-4087f46e28e3', 'Abbott', 'Sara', 'sara@example.com', '949-123-45678', '2467842f-e8f1-4318-a8c1-e372448d47ab'),
		('ebeb777c-63bb-494b-bb17-6ad6941b2592', 'Abbott', 'Adam', 'adam@example.com', '949-123-45679', '2467842f-e8f1-4318-a8c1-e372448d47ab'),
		('db0b1450-aa64-4e32-8a90-37c2a96c3916', 'Abrahamson', 'Jonathan', 'jonathan@example.com', '949-234-4567', '5b879cc8-88a4-4b29-b8d3-2e6a2648528d'),
		('cbf3c949-e5f2-4c71-a70c-d557ad1f97ac', 'Acosta', 'Christine', 'christine@example.com', '949-345-6789', 'b59e496f-a726-4f8d-a507-c89ce4600a5a'),
		('cc472cc2-def3-425f-b599-fd95b09cb2da', 'Abrego', 'Rezvan', 'rezvan@example.com', '949-456-7891', '38007ec9-d013-445d-95d6-c654baa10bcf'),
		('2a05e32c-2450-4358-b7bb-6a9eac90fbf9', 'AbuJohn', 'Selina', 'selina@example.com', '949-567-8912', '997ca9a5-e4bb-4991-bb79-e9d8b86d29bd'),
		('8b8de7a2-5c03-49a0-a90b-9e46f41bef64', 'Aceves', 'Jacob', 'jacob@example.com', '949-678-9123', '04b3b756-d7ea-44e9-af53-df0fe0173989');

INSERT INTO dbo.StudentContact (StudentId, ContactId, Relationship)
VALUES	('99400001', 'fa4380e2-57da-4aa8-844c-4087f46e28e3', 'Mother'),
		('99400001', 'ebeb777c-63bb-494b-bb17-6ad6941b2592', 'Father'),
		('99400011', 'db0b1450-aa64-4e32-8a90-37c2a96c3916', 'Uncle'),
		('99400012', 'cbf3c949-e5f2-4c71-a70c-d557ad1f97ac', 'Mother'),
		('99400013', 'cc472cc2-def3-425f-b599-fd95b09cb2da', 'Father'),
		('99400014', '2a05e32c-2450-4358-b7bb-6a9eac90fbf9', 'Mother'),
		('99400015', '8b8de7a2-5c03-49a0-a90b-9e46f41bef64', 'Father');