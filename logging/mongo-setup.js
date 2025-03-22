rsconf = {
    _id : "rsmongo",
    members: [
        {
            "_id": 0,
            "host": "logging_master_db:27017",
            "priority": 3
        },
        {
            "_id": 1,
            "host": "logging_slave_db1:27017",
            "priority": 2
        }
    ]
}

rs.initiate(rsconf);
